using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.DTOs.Student;
using StudentManagement.Domain.Entities;
using StudentManagement.Domain.Repository;
using AutoMapper;
using StudentManagement.API.DTOs.Course;
using Microsoft.AspNetCore.Authorization;


namespace StudentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StudentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "User")] // Only Users can create students
        //Get all the records from Student entity
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetAll()
         {
          var entities = await _unitOfWork.Student.GetAllAsync();
          var studentDto = _mapper.Map<IEnumerable<StudentDto>>(entities);
          return Ok(studentDto);
         }


        //Get Specific id result
        [HttpGet("{id:int}")] //route constrain validation
        public async Task<ActionResult> Get(int id)
        {
            var StudentFromRepo = await _unitOfWork.Student.GetByIdAsync(id);
            if (StudentFromRepo == null) return NotFound();

            var studentDto = _mapper.Map<StudentDto>(StudentFromRepo);
            return Ok(studentDto);
        }

        //Get all the records of Student with their Enrollment
        [HttpGet("enrollments")]
        public async Task<ActionResult<IEnumerable<Student>>> GetWithEnrollments()
        {
            var studentsFromRepo = await _unitOfWork.Student.GetStudentsWithEnrollments();
            return Ok(studentsFromRepo);
        }

        //Post the data 
        [HttpPost]
        public async Task<ActionResult> Create(CreateStudentReqDto createStudentReqDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var studentModel = _mapper.Map<Student>(createStudentReqDto);
            await _unitOfWork.Student.AddAsync(studentModel);

            var studentDto = _mapper.Map<StudentDto>(studentModel);
            return CreatedAtAction(nameof(Get), new { id = studentModel.ID }, studentDto);
        }


        
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> Update(int id, UpdateStudentReqDto updateStudentReqDto)
        {
            var studentModel = await _unitOfWork.Student.GetByIdAsync(id);
            if (studentModel == null) return NotFound();

            _mapper.Map(updateStudentReqDto, studentModel);

            await _unitOfWork.SaveAsync();
            var studentDto = _mapper.Map<CourseDto>(studentModel);
            return Ok(studentDto);

        }

        //Done with Async
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var studentModel = _unitOfWork.Student.GetById(id);
            if (studentModel == null) return NotFound();

            await _unitOfWork.Student.RemoveAsync(studentModel);
            return NoContent();
        }
    }
}
