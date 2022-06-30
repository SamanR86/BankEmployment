using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;

namespace BankEmployment.Domain.Interfaces
{
    public interface IBaseCrud
    {
        Task<bool> Add(IBase iBase);
        bool Update(IBase iBase);


    }
}
