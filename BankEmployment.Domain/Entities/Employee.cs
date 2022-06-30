using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;

namespace BankEmployment.Domain.Entities
{
    public class Employee:IBase
    {
        public int id;
        public int EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
