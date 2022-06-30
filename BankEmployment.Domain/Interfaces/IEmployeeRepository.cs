using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;
using BankEmployment.Domain.Entities;

namespace BankEmployment.Domain.Interfaces
{
    public interface IEmployeeRepository:IBaseCrud
    {
        Task<List<Employee>> GetAll();
        bool Delete(Employee employee);
        Task<Employee> GetByName(string name);
        Task<Employee> GetById(int id);
      
        

    }
}
