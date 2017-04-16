using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDB.Models;

namespace WebAppDB
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolDBConnectionString")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }

    }

    public class TestDB
    {
        public static void UseDB()
        {
            using(var ctx = new SchoolContext())
            {
                Student stud = new Student() { StudentName = "New Student22" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
