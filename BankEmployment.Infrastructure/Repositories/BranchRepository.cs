using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;
using BankEmployment.Domain.Entities;
using BankEmployment.Domain.Interfaces;
using BankEmployment.Infrastructure.DataContext;

namespace BankEmployment.Infrastructure.Repositories
{
    public class BranchRepository:CrudRepository,IBranchRepository
    {
        private readonly BankEmploymentDBContext _dbContext;

        public BranchRepository(BankEmploymentDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<IBase>> GetByAddress(string address)
        {
            throw new NotImplementedException();
        }
    }
}
