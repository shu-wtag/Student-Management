using Azure.Messaging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.DTOs.Course;
using StudentManagement.Domain.Entities;
using StudentManagement.Domain.Repository;
using AutoMapper; 

namespace StudentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CourseController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("test-error")]
        public IActionResult TestError()
        {  
            throw new InvalidOperationException("This is a test exception to check global exception handling.");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetAll()
        {
            var coursesFromRepo = await _unitOfWork.Course.GetAllAsync();
            if (coursesFromRepo == null || !coursesFromRepo.Any())
                return NotFound();

            // Use AutoMapper to map the courses to CourseDto
            var courseDtos = _mapper.Map<IEnumerable<CourseDto>>(coursesFromRepo);
            return Ok(courseDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CourseDto>> GetById(int id)
        {
            var courseFromRepo = await _unitOfWork.Course.GetByIdAsync(id);
            if (courseFromRepo == null) return NotFound();

            // Map Course to CourseDto
            var courseDto = _mapper.Map<CourseDto>(courseFromRepo);
            return Ok(courseDto);
        }

        [HttpPost]
        public async Task<ActionResult<CourseDto>> Create(CreateCourseReqDto createCourseReqDto)
        {
            var courseModel = _mapper.Map<Course>(createCourseReqDto);
            await _unitOfWork.Course.AddAsync(courseModel);
            

            var courseDto = _mapper.Map<CourseDto>(courseModel);
            return CreatedAtAction(nameof(GetAll), new { id = courseModel.ID }, courseDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var courseModel = await _unitOfWork.Course.GetByIdAsync(id);
            if (courseModel == null) return NotFound();

            await _unitOfWork.Course.RemoveAsync(courseModel);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CourseDto>> Update(int id, UpdateCourseReqDto updateCourseDto)
        {
            var courseModel = await _unitOfWork.Course.GetByIdAsync(id);
            if (courseModel == null) return NotFound();

            // Use AutoMapper to map the updated fields
            _mapper.Map(updateCourseDto, courseModel);

            await _unitOfWork.SaveAsync();
            var courseDto = _mapper.Map<CourseDto>(courseModel);
            return Ok(courseDto);
        }
    }
}
