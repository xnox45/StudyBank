using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySBank.Class
{
    public class Account
    {
        [ Key ]
        public long ID { get; set; }

        public string TaxNumber { get; set; }

        public float Amout { get; set; }

        public float Credit { get; set; }
    }
}
