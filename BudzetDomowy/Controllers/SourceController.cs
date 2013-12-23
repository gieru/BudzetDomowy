using BudzetDomowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BudzetDomowy.Controllers
{
    public class SourceController : Controller
    {
        //
        // GET: /Source/

        public ActionResult Index()
        {
            List<Source> source;
            using (var session = MvcApplication.DocumentStore.OpenSession())
            {
                source = session.Query<Source>().ToList();
            }
            return View(source);
        }

        //
        // GET: /Source/Details/5

        public ActionResult Details(int id)
        {
            Source _source;
            using (var session = MvcApplication.DocumentStore.OpenSession())
            {
                _source = session.Load<Source>(id);      
            }
            return View(_source);
        }

        //
        // GET: /Source/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Source/Create

        [HttpPost]
        public ActionResult Create(Source source)
        {
            using (var session = MvcApplication.DocumentStore.OpenSession())
            {
                session.Store(source);
                session.SaveChanges();
            }

             return RedirectToAction("Index"); 
        }

        //
        // GET: /Source/Edit/5

        public ActionResult Edit(int id)
        {
            Source _source;
            using (var session = MvcApplication.DocumentStore.OpenSession())
            {
                _source = session.Load<Source>(id);
            }
            return View(_source);
        }

        //
        // POST: /Source/Edit/5

        [HttpPost]
        public ActionResult Edit(Source source)
        {
        // TODO: Add update logic here
             using (var session = MvcApplication.DocumentStore.OpenSession())
             {
                 session.Store(source);
                 session.SaveChanges();
             }
             return RedirectToAction("Index");
        }
    }
}
