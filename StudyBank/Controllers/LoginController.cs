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
                    throw new Exception("Model invalido");

                AccountModel accountModel = GetAccount(model);

                if (accountModel == null)
                    throw new Exception("Conta Invalida");

                return View("/Views/Home/Index.cshtml", accountModel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public AccountModel GetAccount(LoginModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    throw new Exception("Model invalido");

                User user = new DataBase().users.Where(x => x.Email.ToLower() == model.Email.ToLower() && x.Password == model.Password).FirstOrDefault();

                if (user == null)
                    throw new Exception("Login inválido");

                Account account = new DataBase().accounts.Where(x => x.TaxNumber == user.Person.TaxNumber).FirstOrDefault();

                AccountModel accountModel = new AccountModel
                {
                    Amount = account.Amout,
                    Credit = account.Credit,
                    Person = new DataBase().persons.Where(x => x.TaxNumber == account.TaxNumber).FirstOrDefault()
                };

                return accountModel;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

    }
}
