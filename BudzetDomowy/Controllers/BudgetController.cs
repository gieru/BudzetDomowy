﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BudzetDomowy.Controllers
{
    public class BudgetController : Controller
    {
        //
        // GET: /Budget/

        public ActionResult Index()
        {
            return View();
        }

    }
}
