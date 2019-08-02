using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class PersonInfo
    {
        public PersonInfo GeneratePersonInfo(string name, string idCard, string phone, string bankCard)
        {
            this.Name = name;
            this.IdCard = idCard;
            this.PhoneNum = phone;
            this.BankCard = bankCard;
            return this;
        }
    }
}
