using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ClassLibrarySBank.Class
{
    public class HistoricTransfer
    {
        [ Key ]
        public long ID { get; set; }     
        
        public int InAccountID { get; set; }

        public int OutAccountID { get; set; }

        public DateTime TransferDate { get; set; }

        public double Amount { get; set; }



    }
}
