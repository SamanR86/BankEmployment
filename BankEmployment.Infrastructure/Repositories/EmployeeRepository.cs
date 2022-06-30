using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;
using BankEmployment.Domain.Entities;
using BankEmployment.Domain.Interfaces;
using BankEmployment.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;

namespace BankEmployment.Infrastructure.Repositories
{
    public class EmployeeRepository:CrudRepository,  IEmployeeRepository

    {
        private readonly BankEmploymentDBContext _dbContext;

        public EmployeeRepository(BankEmploymentDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Employee>> GetAll()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public bool Delete(Employee employee)
        {
            _dbContext.Employees.Remove(employee);
             return true;
        }

        public Task<Employee> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
