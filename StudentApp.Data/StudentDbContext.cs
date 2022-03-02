using Microsoft.EntityFrameworkCore;
using StudentApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> option) : base(option)
        {

        }

        public DbSet<Student> Students { get; set; }    

    }
}
