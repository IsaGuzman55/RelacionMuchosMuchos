using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RelacionMuchosMuchos.Data;
using RelacionMuchosMuchos.Models;
using RelacionMuchosMuchos.Services;

namespace RelacionMuchosMuchos.Services
{
    public class StudentCoursesRepository : IStudentCoursesRepository
    {
        private readonly RelacionesBaseContext _context;

        public StudentCoursesRepository(RelacionesBaseContext context)
        {
            _context = context;
        }

        public IEnumerable<StudentCourse> GetAll(){
            return _context.StudentCourses.Include(e => e.Student).Include(e => e.Course).ToList();
        }
        
    }
}