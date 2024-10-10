using Microsoft.AspNetCore.Mvc;
using StudentManagement.Domain.Entities;
using StudentManagement.Domain.Repository;
using StudentManagement.API.DTOs.Enrollment;
using AutoMapper;

namespace StudentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EnrollmentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Enrollment>>> GetAll()
        {
            var entities = await _unitOfWork.Enrollment.GetAllAsync();
            var enrollDto = _mapper.Map<IEnumerable<Enrollment>>(entities);
            return Ok(enrollDto);
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateEnrollReqDto createEnrollReqDto)
        {
            var enrollModel = _mapper.Map<Enrollment>(createEnrollReqDto);
            await _unitOfWork.Enrollment.AddAsync(enrollModel);

            var EnrollDto = _mapper.Map<Enrollment>(enrollModel);
            return CreatedAtAction(nameof(GetAll), enrollModel);
        }

    }
}
