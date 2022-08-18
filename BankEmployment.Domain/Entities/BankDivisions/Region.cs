using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;

namespace BankEmployment.Domain.Entities
{
    public class Region:IBase
    {
        public string? RegionNumber { get; set; }
        public string? RegionName { get; set; } //Similar to the name of the province
        public string? Description { get; set; }

    }
}
