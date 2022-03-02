using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Core
{
    public class Student
    {
        public Student()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Date = DateTime.Now;
        }
        public Student(string name, string contact) : this()
        {
            Name = name;
            Contact = contact;
        }

        public string Id { get;  private set; }
        public DateTime Date { get; private set; }
        public string Name { get;  private set; }

        public string Contact { get; private set; }

        public void Update(string name, string contact)
        {
            this.Name = name;
            this.Contact = contact;
        }
    }
}
