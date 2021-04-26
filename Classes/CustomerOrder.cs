using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBD.Class 
{
    [Table("customer_orders")]
    public class CustomerOrder
    {
        public CustomerOrder() { }
        public int id { get; set; }
        public int id_partner { get; set; }
        public int id_warehouse { get; set; }
        public int id_employee { get; set; }
        public int id_currency { get; set; }
        public DateTime date { get; set; }
        public Boolean delivery { get; set; }
        public string address_delivery { get; set; }
        public double order_sum { get; set; }

    }
}
