using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudzetDomowy.Models
{
    public class Income : Entry
    {
        public int Source { get; set; }
        public decimal Amount { get; set; }
    }
}