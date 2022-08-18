using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;

namespace BankEmployment.Domain.Entities
{
    public class City:IBase
    {
        public string? CityName { get; set; }
        public string? Description { get; set; }

        public County? County { get; set; }
    }
}
