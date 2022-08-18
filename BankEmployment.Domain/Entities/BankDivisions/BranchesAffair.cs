using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;

namespace BankEmployment.Domain.Entities
{
    public class BranchesAffair:IBase
    {
        public string? BranchAffairNumber { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public Region? Region { get; set; }

    }
}
