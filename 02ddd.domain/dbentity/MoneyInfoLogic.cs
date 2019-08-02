using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class MoneyInfo
    {
        public MoneyInfo GenerateMonryInfo(decimal money, decimal serviceRate)
        {
            this.Money = money;
            this.ServiceRate = serviceRate;
            this.ServiceCharge = this.Money * this.ServiceRate;
            this.TotleMoney = this.Money + this.ServiceCharge;
            return this;
        }
    }
}
