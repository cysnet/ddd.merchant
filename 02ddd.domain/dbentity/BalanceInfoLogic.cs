using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class BalanceInfo
    {
        public BalanceInfo CreateBalance(int status, int source, Guid merchantId, string name, string idCard, string phone, string bankCard)
        {
            this.Status = status;
            this.Source = source;
            this.MerchantId = merchantId;
            this.PersonInfo = new PersonInfo().GeneratePersonInfo(name, idCard, phone, bankCard);
            return this;
        }

        public BalanceInfo SetMoney(decimal money, decimal serviceRate)
        {
            this.MoneyInfo = new MoneyInfo().GenerateMonryInfo(money, serviceRate);
            return this;
        }

        public BalanceInfo SetBlongAccount(string blongAccount)
        {
            this.BlongAccount = blongAccount;
            return this;
        }
    }
}
