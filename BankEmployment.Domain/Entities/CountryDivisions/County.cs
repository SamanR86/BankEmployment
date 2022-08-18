using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;


namespace BankEmployment.Domain.Entities
{
    public class County:IBase
    {
        public string? CountyName  { get; set; }
        public string? Description { get; set;}

        public Province? Province { get; set; }
       
    }
}
