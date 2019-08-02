using ddd.insfrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class BalanceInfo : IAggregationRoot
    {
        public string Code { get; set; } = "Order " + DateTime.Now.ToString();
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTimeOffset CreateTime { get; set; } = DateTimeOffset.Now;

        public int Status { get; set; }
        public bool IsValid { get; set; }
        public int Source { get; set; }
        public Guid MerchantId { get; set; }
        public string BlongAccount { get; set; }
        public MoneyInfo MoneyInfo { get; set; }
        public PersonInfo PersonInfo { get; set; }

    }
}
