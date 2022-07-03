using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySBank.Class
{
    public class HistoricTransfer
    {
        [ Key ]
        public int ID { get; set; }     
        
        public int InAccountID { get; set; }

        public int OutAccountID { get; set; }

        public int TransferDate { get; set; }

        public double Amount { get; set; }


    }
}
