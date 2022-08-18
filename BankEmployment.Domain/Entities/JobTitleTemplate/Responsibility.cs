using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;

namespace BankEmployment.Domain.Entities
{
    public class Responsibility:IBase
    {
        public int Rank { get; set; }
        public string? Description { get; set; }

        public JobTitle? JobTitle { get; set; }
        public OrganizationalRole? OrganizationalRole { get; set; }
        public Degree? Degree { get; set; }
        public Department? Department { get; set; }

    }
}
