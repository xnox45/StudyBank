using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySBank.Class
{
    public class Person
    {
        [Key]
        public long ID { get; set; }
        public string Name { get; set; }
        public string TaxNumber { get; set; }       
        public DateTime BirthDate { get; set; }

    }
}
