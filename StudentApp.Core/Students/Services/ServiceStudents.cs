using StudentApp.Core.Repository;
using StudentApp.Core.Students.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Core.Students.Services
{
    public class ServiceStudents : IServiceStudents
    {
        private readonly IStudentRepository _studentRepository;

        public ServiceStudents(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public string Add(CreateStudentInputModel studentNew)
        {
            var student = new Student(studentNew.Name, studentNew.Contact);

            this._studentRepository.Add(student);

            return "Student Added Successfully...!";
        }

        public List<Student> GetAll()
        {
            return this._studentRepository.GetAll();
        }

        public Student GetById(string id)
        {
            return this._studentRepository.GetById(id);
        }

        public Student Remove(string id)
        {
            var student = this._studentRepository.GetById(id);

            if (student == null)
                return null;

            this._studentRepository.Remove(id);

            return student;
        }

        public Student Update(string id, UpdateStudentInputModel studentChange)
        {
            var student = this._studentRepository.GetById(id);

            if (student == null)
                return null;

            student.Update(studentChange.Name, studentChange.Contact);

            this._studentRepository.Update(student);

            return student;
        }
    }
}
