using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudzetDomowy.Models
{
    public abstract class Entry
    {
        public DateTime Date {get; set;}
        public string Name { get; set; }

    }
}