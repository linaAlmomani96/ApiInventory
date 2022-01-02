using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Entity
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Double ChargeAmount { get; set; }
        public Double VatCharge { get; set; }
        public string Addrees { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }

        [ForeignKey("country")]
        public int country_Id { get; set; }
        public Country country { get; set; }


        [ForeignKey("currency")]
        public int currency_Id { get; set; }
        public Currency currency { get; set; }

    }
}
