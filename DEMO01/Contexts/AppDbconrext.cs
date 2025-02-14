using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEMO01.ENTITTY;
using Microsoft.EntityFrameworkCore;

namespace DEMO01.Contexts
{
    internal class AppDbcontext : DbContext
    {

        public AppDbcontext() :base() 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=AppG03;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet <Employee> Employees    { get; set; }    // Add class to DB
        // DbSet <must be class > 
        public DbSet<Department> Departments { get; set; }   // Add class to DB

    }
}
