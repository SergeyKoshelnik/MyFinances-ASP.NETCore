using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyFinances.Data;
using MyFinances.Models;

namespace MyFinances.Controllers
{
    public class HomeController : Controller
    {
        
        private List<User> users;


        public IActionResult Index()
        {

            using (var db = new ApplicationDBContext())
            {
                users = new List<User>();

                users.AddRange(db.Users);

            }

            if (users.Count != 0)
            {
                ViewBag.Users = new SelectList(users, users[0]);

                return View(users);
            }
            else
                return View();

        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(string txtUserName, string password, string txtQuestion,
            string txtAnswer)
        {
            using (var db = new ApplicationDBContext())
            {
                db.Users.Add(new User()
                {
                    Username = txtUserName,
                    Password = password,
                    Question = txtQuestion,
                    Answer = txtAnswer
                });

                await db.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}