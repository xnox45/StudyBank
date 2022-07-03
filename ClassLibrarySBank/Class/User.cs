﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySBank.Class
{
    public class User
    {
        [Key]
        public long ID { get; set; }

        public string Email { get; set; }
        
        public string Password { get; set; }

        public long PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
