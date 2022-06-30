using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;
using BankEmployment.Domain.Interfaces;
using BankEmployment.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;

namespace BankEmployment.Infrastructure.Repositories
{
    public class CrudRepository:IBaseCrud
    {

        private readonly BankEmploymentDBContext _dbContext;

        public CrudRepository(BankEmploymentDBContext dbContext)
        {
            _dbContext=dbContext;
        }


        public async Task<bool> Add(IBase iBase)
        {
            try
            {
              await _dbContext.AddAsync(iBase);
              return true;
            }
            catch (Exception e)
            {
              return false;
            }
        }



        public bool Update(IBase iBase)
        {
           _dbContext.Update(iBase);
           return true;
        }

       
    }
}
