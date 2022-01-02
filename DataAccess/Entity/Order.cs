using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Entity
{[Table("orders")]
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        [ForeignKey("product")]
        public int Product_Id { get; set; }
        public Product product { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }
        public double GrossAmount { get; set; }
        public double Vat { get; set; }
        public double Discount { get; set; }
        public double NetAmount { get; set; }
        public double ChargeAmount { get; set; }
        public string Paid_Statue { get; set; }
        public DateTime OrderDate { get; set; }



    }
}
