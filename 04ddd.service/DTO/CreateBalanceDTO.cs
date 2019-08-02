using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.service.DTO
{
    public class CreateBalanceDTO
    {
        public int Status { get; set; }
        public bool IsValid { get; set; }
        public int Source { get; set; }
        public Guid MerchantId { get; set; }
        public string BlongAccount { get; set; }
        public decimal Money { get; set; }
        public decimal ServiceRate { get; set; }
        public string Name { get; set; }
        public string IdCard { get; set; }
        public string BankCard { get; set; }
        public string PhoneNum { get; set; }
    }
}
