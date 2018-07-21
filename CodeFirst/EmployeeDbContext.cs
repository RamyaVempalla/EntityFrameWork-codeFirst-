using CodeFirst.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<EmployeeModel> EmployeeDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=Employees; Trusted_Connection=True; MultipleActiveResultSets=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
