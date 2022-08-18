using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;

namespace BankEmployment.Domain.Entities
{
    public class Branch:IBase
    {
        public string? BranchNumber { get; set; }
        public string? Name { get; set; }
        public string? BranchType { get; set; } //Bank branch or management branch
        public string? OriginBank { get; set; }
        public string? OldName { get; set; }
        public string? Address { get; set; }
        public string? PostalCode { get; set; }
        public string? OwnershipStatus { get; set; } //Owner or tenant
        public string? ActivityStatus { get; set; } //Working or closed
        public string? OpeningDate { get; set; }
        public string? ClosingDate { get; set; }
        public string? Description { get; set; }

        public Area? Area { get; set; }
        public County? County { get; set; }

    }
}
