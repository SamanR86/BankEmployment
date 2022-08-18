using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;


namespace BankEmployment.Domain.Entities
{
    public class Appointment:IBase
    {
        public Employee? Employee { get; set; }
        public string? Date { get; set; }
        public Branch? Branch { get; set; }
        public Responsibility? Responsibility { get; set; }
        public string? ChartStatus { get; set; }   //inside or outside of BranchChart 


    }
}
