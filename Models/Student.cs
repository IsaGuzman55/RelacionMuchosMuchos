using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RelacionMuchosMuchos.Models{
    public class Student{
        public int Id {get; set;}

        [Required]
        public string Names {get; set;}

        [Required]
        public string LastName {get; set;}

        [Required]
        public string Email {get; set;}

        [JsonIgnore]
        public List<StudentCourse>? StudentCourse { get; set; }
    
       
    }
}