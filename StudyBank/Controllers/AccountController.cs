using ClassLibrarySBank.Class;
using ClassLibrarySBank.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyBank.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Account(Account account)
        {
            Person person = new DataBase().persons.Where(x => x.TaxNumber == account.TaxNumber).FirstOrDefault();

            AccountModel model = new AccountModel{
                Person = person, Amount = account.Amout,
                Credit = account.Credit
            };

            return View(model);
        }
    }
}
