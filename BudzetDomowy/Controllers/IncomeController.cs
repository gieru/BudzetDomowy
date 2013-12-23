using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BudzetDomowy.Controllers
{
    public class IncomeController : Controller
    {
        //
        // GET: /Income/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Income/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Income/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Income/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Income/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Income/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Income/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Income/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
