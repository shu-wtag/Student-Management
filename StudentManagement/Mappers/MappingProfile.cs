using AutoMapper;
using StudentManagement.Domain.Entities;
using StudentManagement.API.DTOs.Course;
using StudentManagement.API.DTOs.Student;
using StudentManagement.API.DTOs.Enrollment;
using StudentManagement.API.DTOs.Teacher;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        //Course Mappings
        CreateMap<Course, CourseDto>();
        CreateMap<CreateCourseReqDto, Course>();
        CreateMap<UpdateCourseReqDto, Course>();

        //Student Mappings
        CreateMap<Student, StudentDto>();
        CreateMap<CreateStudentReqDto, Student>();
        CreateMap<UpdateStudentReqDto, Student>();


        //Enrollment Mappings
        CreateMap<Enrollment, EnrollmentDto>();
        CreateMap<CreateEnrollReqDto, Enrollment>();


        //Teacher Mappings
        CreateMap<Teacher, TeacherDto>();
        CreateMap<UpdateTeacherDto, Teacher>();
    }
}
