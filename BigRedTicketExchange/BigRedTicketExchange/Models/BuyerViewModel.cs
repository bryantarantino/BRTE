using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigRedTicketExchange.Models
{
    public class BuyerViewModel
    {
        public ApplicationUser User { get; set; }
        public Ticket Ticket { get; set; }
    }
}