using BudzetDomowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BudzetDomowy.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/

        public ActionResult Index()
        {
            List<Category> categories;
            using (var session = MvcApplication.DocumentStore.OpenSession())
            {
                categories = session.Query<Category>().ToList();
            }

            return View(categories);
        }

        //
        // GET: /Category/Details/5

        public ActionResult Details(int id)
        {
            Category cat;
            using (var session = MvcApplication.DocumentStore.OpenSession())
            {
                cat = session.Load<Category>(id);
            }
            return View(cat);
        }

        //
        // GET: /Category/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Category/Create

        [HttpPost]
        public ActionResult Create(Category category)
        {
            using (var session = MvcApplication.DocumentStore.OpenSession())
            {
                session.Store(category);
                session.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        //
        // GET: /Category/Edit/5

        public ActionResult Edit(int id)
        {
            Category cat;
            using (var session = MvcApplication.DocumentStore.OpenSession())
            {
                cat = session.Load<Category>(id);
            }
            return View(cat);
        }

        //
        // POST: /Category/Edit/5

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            using (var session = MvcApplication.DocumentStore.OpenSession())
            {
                session.Store(category);
                session.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
