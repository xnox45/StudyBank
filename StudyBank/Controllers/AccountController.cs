using ClassLibrarySBank.Class;
using ClassLibrarySBank.Model;
using ClassLibrarySBank.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace StudyBank.Controllers
{

    public class AccountController : Controller
    {
        public IActionResult Account(Account account)
        {
            Person person = new Context().Persons.Where(x => x.TaxNumber == account.TaxNumber).FirstOrDefault();

            AccountModel model = new AccountModel
            {
                Person = person,
                Amount = account.Amout,
                Credit = account.Credit
            };


            return View(model);
        }


        [HttpPost]
        public void Transfer(TransferModel model)
        {
            Context context = new Context();

            //Nessa linha estou usando para fazer a comparação se o CPF de quem vai enviar realmente existe
            var accountOut = context.Accounts.Where(x => x.TaxNumber == model.OutTaxNumber).FirstOrDefault();

            //Nessa linha estou usando para fazer a comparação se o CPF de quem vai receber realmente existe
            var accountIn = context.Accounts.Where(x => x.TaxNumber == model.InTaxNumber).FirstOrDefault();


            //Verificando se o dinheiro na conta de quem vai enviar realmente consta
            if (accountOut.Amout >= model.Amount)
            {

                //retirando o dinheiro de quem vai enviar e enviando para quem vai receber
                accountOut.Amout = accountOut.Amout - (float)model.Amount;
                accountIn.Amout = accountIn.Amout + (float)model.Amount;

            }

            var historic = new HistoricTransfer();

            historic.ID = historic.ID++;
            historic.InAccountID = (int)accountIn.ID;
            historic.OutAccountID = (int)accountOut.ID;
            historic.TransferDate = DateTime.Now;
            historic.Amount = accountOut.Amout;

            context.HistoricTransfers.Add(historic);
            context.SaveChanges();
            
        }
    }
}
