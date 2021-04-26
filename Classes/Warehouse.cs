using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBD.Class 
{
    [Table("warehouse")]
    public class Warehouse
    {
        public Warehouse() { }
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }
}
