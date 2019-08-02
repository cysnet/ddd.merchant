using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class MoneyInfo
    {
        public decimal Money { get; set; }
        public decimal ServiceRate { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal TotleMoney { get; set; }
    }
}
