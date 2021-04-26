using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBD.Class 
{
    [Table("partner")]
    public class Partner
    {
        public Partner() { }
        public int id { get; set; }
        public string fio { get; set; }
        public Boolean supplier { get; set; }
        public string country { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
    }
}
