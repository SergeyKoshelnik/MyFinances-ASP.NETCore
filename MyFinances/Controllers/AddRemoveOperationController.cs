using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFinances.Data;
using MyFinances.Models;

namespace MyFinances.Controllers
{
    public class AddRemoveOperationController : Controller
    {

        /*Add Methods*/

        
        public IActionResult AddCost(int id)
        {
            ViewBag.UserId = id;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCost(int id, string txtCommentForCost, string txtSummofCost)
        {

            using (var db = new ApplicationDBContext())
            {

                db.Transactions.Add(new Transaction()
                {
                    DateTimeTransaction = DateTime.Today,
                    Cost = Convert.ToDouble(txtSummofCost),
                    Income = 0.0,
                    CommentforCategory = txtCommentForCost,
                    UserId = id
                });

                await db.SaveChangesAsync();

            }

            return View();
        }

        public IActionResult AddIncome(int id)
        {
            ViewBag.UserId = id;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddIncome(int id, string txtCommentForIncome, string txtSummofIncome)
        {

            using (var db = new ApplicationDBContext())
            {

                db.Transactions.Add(new Transaction()
                {
                    DateTimeTransaction = DateTime.Today,
                    Cost = 0.0,
                    Income = Convert.ToDouble(txtSummofIncome),
                    CommentforCategory = txtCommentForIncome,
                    UserId = id
                });

                await db.SaveChangesAsync();

            }

            return View();
        }

        public IActionResult AddDebt(int id)
        {
            ViewBag.UserId = id;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddDebt(int id, string txtNameForDebt, string txtSummofDebt)
        {

            using (var db = new ApplicationDBContext())
            {

                db.Debts.Add(new Debt()
                {
                    DateEndDate = DateTime.Today,
                    DebtName = txtNameForDebt,
                    SummofDebt = Convert.ToDouble(txtSummofDebt),
                    UserId = id
                });

                await db.SaveChangesAsync();

            }

            return View();
        }

        public IActionResult AddAccumulation(int id)
        {
            ViewBag.UserId = id;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAccumulation(int id,
            string txtAccumulationName,
            string txtSummofAccumulation,
            string txtCommentforAccumulation)
        {

            using (var db = new ApplicationDBContext())
            {

                db.Accumulations.Add(new Accumulation()
                {
                    DateTimeAccumulation = DateTime.Today,
                    AccumulationName = txtAccumulationName,
                    SummofAccumulation = Convert.ToDouble(txtSummofAccumulation),
                    CommentforAccumulation = txtCommentforAccumulation,
                    Accumulated = 0.0,
                    Contributed = 0.0,
                    UserId = id
                });

                await db.SaveChangesAsync();

            }

            return View();
        }

        /*Delete Methods*/

        public async Task<IActionResult> DeleteCost(int? id)
        {

            using (var db = new ApplicationDBContext())
            {
                if (id != null)
                {
                    var cost = db.Transactions.FirstOrDefault(t =>
                        t.Id == id);

                    if (cost != null)
                    {
                        db.Transactions.Remove(cost);
                        await db.SaveChangesAsync();
                    }
                }

                return Content("Удалено успешно");
                
            }

        }

        public async Task<IActionResult> DeleteIncome(int? id)
        {

            using (var db = new ApplicationDBContext())
            {
                if (id != null)
                {
                    var income = db.Transactions.FirstOrDefault(t =>
                        t.Id == id);

                    if (income != null)
                    {
                        db.Transactions.Remove(income);
                        await db.SaveChangesAsync();
                    }
                }
            }

            return Content("Удалено успешно");

        }

        public async Task<IActionResult> DeleteDebt(int? id)
        {

            using (var db = new ApplicationDBContext())
            {
                if (id != null)
                {
                    var debt = db.Debts.FirstOrDefault(t =>
                        t.Id == id);

                    if (debt != null)
                    {
                        db.Debts.Remove(debt);
                        await db.SaveChangesAsync();
                    }
                }
            }

            return Content("Удалено успешно");

        }

        public async Task<IActionResult> DeleteAccumulation(int? id)
        {

            using (var db = new ApplicationDBContext())
            {
                if (id != null)
                {
                    var accumulation = db.Accumulations.FirstOrDefault(t =>
                        t.Id == id);

                    if (accumulation != null)
                    {
                        db.Accumulations.Remove(accumulation);
                        await db.SaveChangesAsync();
                    }
                }
            }

            return Content("Удалено успешно");

        }

    }
}