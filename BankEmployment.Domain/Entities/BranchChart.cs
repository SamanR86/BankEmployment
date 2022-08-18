using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;


namespace BankEmployment.Domain.Entities
{
    public class BranchChart:IBase
    {
        public Branch? Branch { get; set; }
        public Responsibility? Responsibility { get; set; }
        public Employee? Employee { get; set; }  //An employee in a position of responsibility
        public Employee? Agent { get; set; } //An employee in a place of responsibility
        public int Priority { get; set; }


    }
}
