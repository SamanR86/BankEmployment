using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;

namespace BankEmployment.Domain.Entities
{
    public class Province:IBase
    {
        public string? ProvinceName { get; set; }
        public string? Description { get; set; }
               
    }
}
