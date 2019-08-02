using ddd.domain.dbentity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.Interfaces
{
    public interface IBalanceRespository
    {
        BalanceInfo CreateBalanceInfo(BalanceInfo balanceInfo);
    }
}
