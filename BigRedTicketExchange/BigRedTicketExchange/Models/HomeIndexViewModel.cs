using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigRedTicketExchange.Models
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
            Sports = new List<Sport>();
        }
        public ICollection<Sport> Sports { get; set; }

    }
}