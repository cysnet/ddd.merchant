using ddd.domain.dbentity;
using ddd.domain.Implements;
using ddd.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.respository
{
    public class BalanceRespository : IBalanceRespository
    {
        BalanceEFCoreContext _balanceEFCoreContext;
        public BalanceRespository(BalanceEFCoreContext balanceEFCoreContext)
        {
            this._balanceEFCoreContext = balanceEFCoreContext;
        }
        public BalanceInfo CreateBalanceInfo(BalanceInfo balanceInfo)
        {
            _balanceEFCoreContext.BalanceInfo.Add(balanceInfo);
            return balanceInfo;
        }
    }
}
