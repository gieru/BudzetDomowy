using BudzetDomowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BudzetDomowy.Controllers
{
    public class ExpenseController : BaseController
    {
        
        //
        // GET: /Expense/Details/5

        public ActionResult Details(int id)
        {
            var expense = DocumentSession.Load<Expense>(id);
            return View();
        }

        //
        // GET: /Expense/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Expense/Create

        [HttpPost]
        public ActionResult Create(Expense expense)
        {
            DocumentSession.Store(expense);
            DocumentSession.SaveChanges();

            return RedirectToAction("Index");
           
        }

        //
        // GET: /Expense/Edit/5

        public ActionResult Edit(int id)
        {
            var expense = DocumentSession.Load<Expense>(id);
            return View(expense);
        }

        //
        // POST: /Expense/Edit/5

        [HttpPost]
        public ActionResult Edit(Expense expense)
        {
            DocumentSession.Store(expense);
            DocumentSession.SaveChanges();
            return RedirectToAction("Index");
        }

        
        //
        // POST: /Expense/Delete/5

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var expense = DocumentSession.Load<Expense>(id);
            DocumentSession.Delete(expense);
 
           return RedirectToAction("Index");
 
        }
    }
}
