using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBD.Class 
{
    [Table("nomenclature")]
    public class Nomenclature
    {
        public Nomenclature() { }
        public int id { get; set; }
        public string name { get; set; }
        public string manufacturer { get; set; }
        public string country { get; set; }
    }
}
