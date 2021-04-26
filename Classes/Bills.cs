using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBD.Class 
{
    [Table("bills")]
    public class Bills
    {
        public Bills() { }
        public int id { get; set; }
        public int id_currency { get; set; }
        public string number_bill { get; set; }
    }
}
