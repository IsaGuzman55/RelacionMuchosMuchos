using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RelacionMuchosMuchos.Models{
    public class StudentCourse{

        [Required]
        public int StudentId {get; set;}
        /* Entidad "Student" */
        public Student Student { get; set; }

        [Required]
        public int CourseId {get; set;}
        /*  Entidad "Course" */
        public Course Course { get; set; }

        [Required]
        public string Status {get; set;}
       
    }
}

