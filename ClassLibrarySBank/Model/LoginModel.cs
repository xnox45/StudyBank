using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySBank.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email Necessario")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha Necessaria")]
        public string Password { get; set; }
    }
}
