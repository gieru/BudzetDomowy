using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudzetDomowy.Models
{
    public class Expense : Entry
    {
        public int Category { get; set; }
        public decimal Price { get; set; }



    }
}