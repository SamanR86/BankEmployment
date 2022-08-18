using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;

namespace BankEmployment.Domain.Entities
{
    public class Department:IBase
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

    }
}
