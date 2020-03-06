using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyFinances.Data;
using MyFinances.Models;

namespace MyFinances.Controllers
{
    public class AccountController : Controller
    {

        private List<Transaction> listTransactions;
        private List<Debt> listDebts;
        private List<Accumulation> listAccumulations;

        public IActionResult MainPage(int formEnterUser, string password)
        {

            using (var db = new ApplicationDBContext())
            {
                User user = db.Users.FirstOrDefault(u =>
                    u.Id == formEnterUser);

                // Check password

                if (user != null && user.Password == password)
                {
                    // Transactions of the selected user

                    listTransactions = new List<Transaction>();

                    foreach (var item in db.Transactions)
                    {
                        if (item.UserId == formEnterUser)
                        {
                            listTransactions.Add(item);
                        }
                    }

                    // Debts of the selected user

                    listDebts = new List<Debt>();

                    foreach (var item in db.Debts)
                    {
                        if (item.UserId == formEnterUser)
                        {
                            listDebts.Add(item);
                        }
                    }

                    // Accumulations of the selected user

                    listAccumulations = new List<Accumulation>();

                    foreach (var item in db.Accumulations)
                    {
                        if (item.UserId == formEnterUser)
                        {
                            listAccumulations.Add(item);
                        }
                    }
                    
                    ViewBag.User = user;
                    ViewBag.Transactions = listTransactions;
                    ViewBag.Debts = listDebts;
                    ViewBag.Accumulations = listAccumulations;

                    return View();

                }
                
                else
                    return View("~/Views/Errors/ErrorNullException.cshtml", "Пароль неверный");
            }

        }
    }
}