using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;


namespace BankEmployment.Domain.Entities
{
    public class Transfer:IBase
    {
        public Employee? Employee { get; set; }
        public Branch? Branch { get; set; }
        public Responsibility? Responsibility { get; set; }
        public string? Date { get; set; }
        public string? Term { get; set; } //long term or Fixed term
        public int TermDurationDays { get; set; }
    
    }
}
