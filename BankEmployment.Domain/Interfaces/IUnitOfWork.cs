﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEmployment.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();

    }
}
