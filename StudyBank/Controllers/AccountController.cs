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

            AccountModel model = new AccountModel {
                Person = person, Amount = account.Amout,
                Credit = account.Credit
            };
            

            return View(model);
        }

        [HttpPost]
        public bool Transfer(TransferModel model)
        {
            DataBase database = new DataBase();
            
          //Nessa linha estou usando para fazer a comparação se o CPF de quem vai enviar realmente existe
            var accountOut = database.accounts.Where(x => x.TaxNumber == model.OutTaxNumber).FirstOrDefault();
          
            //Verificando se o dinheiro na conta de quem vai enviar realmente consta
            if(accountOut.Amout >= model.Amount)
            {

                var accountIn = database.accounts.Where(x => x.TaxNumber == model.InTaxNumber).FirstOrDefault();

                //retirando o dinheiro de quem vai enviar e enviando para quem vai receber
                accountOut.Amout = accountOut.Amout - model.Amount;
                accountIn.Amout = accountIn.Amout + model.Amount;

            }

            //retorno positivo ou negativo
            else
            {
                return false;
            }
            return true;
        }
    }
}
