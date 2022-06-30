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



    }
}
