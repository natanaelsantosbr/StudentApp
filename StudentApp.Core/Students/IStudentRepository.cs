using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Core.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        void Add(Student student);
        Student GetById(string id);
        void Update(Student student);
        void Remove(string id);
    }
}
