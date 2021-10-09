using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstApp.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }

    public class MyContext : DbContext
    {

        public MyContext():base("Server=.;Database=OilSchool;Trusted_Connection=True;")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}