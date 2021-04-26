using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBD.Class 
{
    [Table("employees")]
    public class Employees
    {
        public Employees() { }
        public int id { get; set; }
        public string fio { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string position { get; set; }
    }
}
