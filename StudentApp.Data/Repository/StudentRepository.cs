using StudentApp.Core;
using StudentApp.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Data.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _db;

        public StudentRepository(StudentDbContext db)
        {
            _db = db;
        }

        public void Add(Student student)
        {
            this._db.Students.Add(student);
            this._db.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return this._db.Students.ToList();
        }

        public Student GetById(string id)
        {
            return this._db.Students.FirstOrDefault(a=> a.Id == id);    
        }

        public void Remove(string id)
        {
            var student = this._db.Students.FirstOrDefault(a => a.Id == id);

            this._db.Students.Remove(student);
            this._db.SaveChanges();            
        }

        public void Update(Student student)
        {
            this._db.SaveChanges();
        }
    }
}
