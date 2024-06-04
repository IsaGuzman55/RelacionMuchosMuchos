using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RelacionMuchosMuchos.Models{
    public class Course{

        public int Id {get; set;}

        [Required]
        public string Name {get; set;}

        [Required]
        public string Description {get; set;}

        [Required]
        public int AuthorId {get; set;}

        [JsonIgnore]
        public List<StudentCourse>? StudentCourse { get; set; }
    
       
    }
}