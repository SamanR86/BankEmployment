using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.Interfaces;
using BankEmployment.Infrastructure.DataContext;

namespace BankEmployment.Infrastructure.Repositories
{
    public class UnitOfWorkRepository:IUnitOfWork
    {
        private readonly BankEmploymentDBContext _dbContext;

        public UnitOfWorkRepository(BankEmploymentDBContext dbContext )
        {
            _dbContext=dbContext;
        }
        public async Task<bool> Commit()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            } 
        }
    }
}
