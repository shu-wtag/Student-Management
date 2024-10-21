using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.DTOs.Teacher;
using StudentManagement.Domain.Repository;
using AutoMapper;
using StudentManagement.API.DTOs.Course;
using StudentManagement.API.DTOs.Teacher;
using Microsoft.AspNetCore.Authorization;
using StudentManagement.API.DTOs.Student;

namespace StudentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TeacherController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        //public async Task<ActionResult<IEnumerable<TeacherDto>>> GetAll()
        //{
        //    try
        //    {
        //        var teacherFromRepo = await _unitOfWork.Teacher.GetAllAsync();
        //        if (teacherFromRepo == null || !teacherFromRepo.Any())
        //            return NotFound();

        //        var teacherDtos = _mapper.Map<IEnumerable<TeacherDto>>(teacherFromRepo);
        //        return Ok(teacherDtos);
        //    }
        //    catch(Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        [Authorize]
        public async Task<ActionResult<IList<TeacherDto>>> GetAll()
        {
            try
            {
                var teachersFromRepo = await _unitOfWork.Teacher.GetAllAsync();

                var teacherDtos = _mapper.Map<IEnumerable<TeacherDto>>(teachersFromRepo);
                return Ok(teacherDtos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<TeacherDto>> GetById(int id)
        {
            var teacherFromRepo = await _unitOfWork.Teacher.GetByIdAsync(id);

            var teacherDto = _mapper.Map<TeacherDto>(teacherFromRepo);
            return Ok(teacherDto);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<TeacherDto>> Update(int id, UpdateTeacherDto updateTeacherDto)
        {
            var teacherModel = await _unitOfWork.Teacher.GetByIdAsync(id);
            if (teacherModel == null) return NotFound();

            _mapper.Map(updateTeacherDto, teacherModel);

            await _unitOfWork.SaveAsync();
            var teacherDto = _mapper.Map<TeacherDto>(teacherModel);
            return Ok(teacherDto);

        }
    }
    
}
