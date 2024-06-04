using Microsoft.EntityFrameworkCore;
using RelacionMuchosMuchos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RelacionMuchosMuchos.Services;

namespace RelacionMuchosMuchos.Data{
    public class RelacionesBaseContext : DbContext{
        public RelacionesBaseContext(DbContextOptions<RelacionesBaseContext> options) : base(options){

        }

        public DbSet<Student> Students {get; set;}
        public DbSet<Course> Courses {get; set;}
        public DbSet<StudentCourse> StudentCourses {get; set;}


        /* -------------------- Ya que "StudentCourse" no tiene una Foreign Key se le debe crear una clave primaria compuesta para que me permita listar ---------------------------  */
        /* Crear una clave primaria compuesta para la entidad "StudentCourse" a partir de StudentId y CourseId*/

        /* El metodo "OnModelCreating" es propio del "DbContext" */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                /*  La combinación de estas dos propiedades(StudentId, CourseId) será la clave primaria de la entidad "StudentCourse". */
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            base.OnModelCreating(modelBuilder);
        }

    }
}