using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBD.Class 
{
    [Table("currencies")]
    public class Currencies
    {
        public Currencies()  { }
        public int id { get; set; }
        public string name { get; set; }

    }
}
