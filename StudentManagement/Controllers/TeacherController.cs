using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.DTOs.Teacher;
using StudentManagement.Domain.Repository;
using AutoMapper;
using StudentManagement.API.DTOs.Course;

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
        public async Task<ActionResult<IEnumerable<TeacherDto>>> GetAll()
        {
            
            var entities = await _unitOfWork.Teacher.GetAllAsync();
            var TeacherDto = _mapper.Map<IEnumerable<TeacherDto>>(entities);
            return Ok(TeacherDto);
        }



        //Get Specific id result
        [HttpGet("{id:int}")]
        public async Task<ActionResult<TeacherDto>> GetById(int id)
        {
            var teacherFromRepo = await _unitOfWork.Teacher.GetByIdAsync(id);

            var teacherDto = _mapper.Map<TeacherDto>(teacherFromRepo);
            return Ok(teacherDto);
        }
    }
    
}
