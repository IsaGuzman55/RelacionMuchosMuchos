using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RelacionMuchosMuchos.Models;
using RelacionMuchosMuchos.Services;

namespace RelacionMuchosMuchos.Services
{
    public interface IStudentCoursesRepository
    {
        IEnumerable<StudentCourse> GetAll();
    }
}