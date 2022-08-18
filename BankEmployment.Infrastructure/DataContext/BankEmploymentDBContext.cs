using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankEmployment.Infrastructure.DataContext
{
    public class BankEmploymentDBContext:DbContext

    {
        public BankEmploymentDBContext(DbContextOptions<BankEmploymentDBContext> options):base(options)
        {
            
        }


        public DbSet<Branch> Branches { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<BranchChart> BranchesChart { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
      
        public DbSet<Area> Areas { get; set; }
        public DbSet<BranchesAffair> BranchesAffairs { get; set; }
        public DbSet<Region> Regions { get; set; }

        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Province> Provinces { get; set; }

        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<OrganizationalRole> OrganizationalRoles { get; set; }  
        public DbSet<Responsibility> Responsibilities { get; set; }



    }
}
