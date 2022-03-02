using StudentApp.Core.Students.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Core.Students.Services
{
    public interface IServiceStudents
    {
        List<Student> GetAll();
        string Add(CreateStudentInputModel studentNew);
        Student GetById(string id);
        Student Update(string id, UpdateStudentInputModel student);
        Student Remove(string id);
    }
}
