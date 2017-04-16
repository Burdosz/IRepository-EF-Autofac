using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDB;
using WebAppDB.Models;
using WebAppRepository.Interfaces;

namespace WebAppRepository.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private SchoolContext context;

        public StudentRepository(SchoolContext context)
        {
            this.context = context;
        }

        public IEnumerable<Student> List => context.Students.ToList();

        public void Add(Student entity)
        {
            context.Students.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Student entity)
        {
            if (context.Students.Find(entity.StudentID) != null)
            {
                context.Students.Remove(entity);
                context.SaveChanges();
            }
        }

        public Student FindById(int Id)
        {
            return context.Students.Find(Id);
        }
        
    }
}
