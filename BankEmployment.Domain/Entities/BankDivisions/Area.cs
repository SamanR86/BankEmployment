using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;

namespace BankEmployment.Domain.Entities
{
    public class Area:IBase
    {
        public string? AreaNumber{ get; set; }
        public string? Name { get; set;}
        public string? Description { get; set;}

        public BranchesAffair? BranchesAffair { get; set; }
        
    }
}
