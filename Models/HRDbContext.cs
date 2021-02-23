using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class HRDbContext:DbContext
    {
        public HRDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<PersonalDetails> PersonalDetails { get; set; }
        public DbSet<EmployeeRoleMap> EmployeeRoleMap { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { DepId = 1, Name = "BusinessDevelopment" },
                new Department { DepId = 2, Name = "TechnicalDevelopement" },
                new Department { DepId = 3, Name = "HumanResource" },
                new Department { DepId = 4, Name = "GeneralStaff" }
            );
            modelBuilder.Entity<Designation>().HasData(
               new Designation { DesgId = 1, Name = "ProjetManager" },
               new Designation { DesgId = 2, Name = "Developer" },
               new Designation { DesgId = 3, Name = "Tester" },
               new Designation { DesgId = 4, Name = "Teamlead" },
                new Designation {DesgId = 5, Name = "Admin" }
           );
            modelBuilder.Entity<EmployeeType>().HasData(
                           new EmployeeType { TypeId = 1, Type = "Full-Time" },
                           new EmployeeType { TypeId = 2, Type = "Part-Time" },
                           new EmployeeType { TypeId = 3, Type = "Trainee" },
                           new EmployeeType { TypeId = 4, Type = "Intern" }
                       );
            modelBuilder.Entity<Roles>().HasData(
                           new Roles { RoleId = 1, Name = "Admin" },
                           new Roles { RoleId = 2, Name = "Hr" },
                           new Roles { RoleId = 3, Name = "Employee" }                        
                       );
            modelBuilder.Entity<Gender>().HasData(
                           new Gender { GenderId = 1, Name = "Female" },
                           new Gender { GenderId = 2, Name = "Male" },
                           new Gender { GenderId = 3, Name = "Others" }
                       );
        }
    }
}

