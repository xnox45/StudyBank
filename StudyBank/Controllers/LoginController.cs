using ClassLibrarySBank.Class;
using ClassLibrarySBank.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace StudyBank.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(LoginModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new Exception("Model invalido");
                }

                User user = new DataBase().users.Where(x => x.Email == model.Email && x.Password == model.Password).FirstOrDefault();

                if (user.Equals(null))
                    throw new Exception("Login inválido");

                Account account = new DataBase().accounts.Where(x => x.TaxNumber == user.Person.TaxNumber).FirstOrDefault();

                AccountModel accountModel = new AccountModel { Amount = account.Amout, Credit = account.Credit,
                    Person = new DataBase().persons.Where(x => x.TaxNumber == account.TaxNumber).FirstOrDefault()
                };

                return View("/Views/Home/Index.cshtml", accountModel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
