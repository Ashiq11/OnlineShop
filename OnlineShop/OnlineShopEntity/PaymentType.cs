using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopEntity
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeID { get; set; }
        public string TypeName { get; set; }

        public List<Payment> Payments { get; set; }

    }
}
