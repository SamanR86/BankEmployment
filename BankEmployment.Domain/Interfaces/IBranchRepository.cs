using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;

namespace BankEmployment.Domain.Interfaces
{
    public interface IBranchRepository:IBaseCrud
    {
        Task<List<IBase>> GetByAddress(string address);

    }
}
