using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class PersonInfo
    {
        public string Name { get; set; }
        public string IdCard { get; set; }
        public string BankCard { get; set; }
        public string PhoneNum { get; set; }
    }
}
