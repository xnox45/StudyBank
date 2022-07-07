using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySBank.Model
{
    public class TransferModel
    {
        public float Amount         { get; set; }

        public string InTaxNumber   { get; set; }

        public string OutTaxNumber  { get; set; }

        public static void Update(object modifiedOrders)
        {
            throw new NotImplementedException();
        }
    }
}
