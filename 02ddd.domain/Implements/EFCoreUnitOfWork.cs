using ddd.insfrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.Implements
{
    public class EFCoreUnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly BalanceEFCoreContext context;
        public EFCoreUnitOfWork(BalanceEFCoreContext context)
        {
            this.context = context;
        }

        public void Commit()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
