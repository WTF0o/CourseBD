using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBD.Class 
{
    [Table("customer_order_table")]
    public class CustomerOrderTable
    {
        public CustomerOrderTable() { }
        public int id { get; set; }
        public int id_customer_order { get; set; }
        public int id_nomenclature { get; set; }
        public double count { get; set; }
        public double cost { get; set; }
        public double sum { get; set; }

    }
}
