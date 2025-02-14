using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_ASSIGNMENT01.Entity_ITI;
using Microsoft.EntityFrameworkCore;

namespace EF_ASSIGNMENT01.Context
{
    internal class ItiDbContext :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=AppITI;;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Instructor> Instructors  { get; set; }

        public DbSet<Depertment> Depertments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
