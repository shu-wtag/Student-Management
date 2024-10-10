using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.DataAccess.Implementation;
using StudentManagement.API.DTOs.Teacher;
using StudentManagement.Domain.Repository;

namespace StudentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TeacherController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var TeachersModel = _unitOfWork.Teacher.GetAll().Select(u => u.ID).ToList();
            return Ok(TeachersModel);
        }
        //[HttpGet("{id}")]
        //public ActionResult Get(int id)
        //{
        //    var TeacherFromRepo = _unitOfWork.Teacher.GetById(id);
        //    return Ok(TeacherFromRepo.ToTeacherDto());
        //}
    }
    
}
