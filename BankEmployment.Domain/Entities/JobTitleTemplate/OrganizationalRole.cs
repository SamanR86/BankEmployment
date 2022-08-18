using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;

namespace BankEmployment.Domain.Entities
{
    public class OrganizationalRole:IBase
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
