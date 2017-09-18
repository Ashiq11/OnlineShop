using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopEntity
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public string Type { get; set; }
        public double CreditAmount { get; set; }
        public double DebitAmount { get; set; }
        public double Balance { get; set; }

        public PaymentType paymentType { get; set; }
        //public List<Order> Orders { get; set; }


    }
}
