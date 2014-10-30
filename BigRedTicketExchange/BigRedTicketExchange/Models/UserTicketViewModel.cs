using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigRedTicketExchange.Models
{
    public class UserTicketViewModel
    {
        public ApplicationUser User { get; set; }
        public Game Game { get; set; }
    }
}