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
        public int BranchCode { get; set; }     
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public DateTime OpeningDate { get; set; }
        
    }
}
