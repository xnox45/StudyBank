using ClassLibrarySBank.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySBank.Model
{
    public class AccountModel
    {
        public Person Person { get; set; }

        public float Amount { get; set; }
        
        public float Credit { get; set; }
    }
}
