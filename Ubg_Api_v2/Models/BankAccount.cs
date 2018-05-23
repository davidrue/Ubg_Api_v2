using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ubg_Api_v2.Models
{
    public class BankAccount
    {
        public String Id { get; set; }

        public String Iban { get; set; }

        public int Priority { get; set; }

        // Foreign Key
        public String Actor_Id { get; set; }
    }
}