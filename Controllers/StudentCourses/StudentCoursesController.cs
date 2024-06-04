using Microsoft.EntityFrameworkCore;
using RelacionMuchosMuchos.Models;
using RelacionMuchosMuchos.Services;
using RelacionMuchosMuchos.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionMuchosMuchos.Controllers{
    public class StudentCoursesController : ControllerBase{
        private readonly IStudentCoursesRepository _studentCoursesRepository;
        public StudentCoursesController(IStudentCoursesRepository studentCoursesRepository){
            _studentCoursesRepository = studentCoursesRepository;
        }

        [HttpGet]
        [Route("api/studentCourses")]
        public IActionResult GetStudentCourses(){
            var studentCourses = _studentCoursesRepository.GetAll();
            if(!studentCourses.Any()){
                return Ok(new {Message = "No hay estudiantes registrados en los cursos"});
            }
            return Ok(studentCourses);
        }
    }
}