using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BigRedTicketExchange.Models
{
    public class Sport
    {
        public Sport()
        {
            Games = new List<Game>();
        }

        public int SportID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Game> Games { get; set; }

    }
    public class Game
    {
        public Game()
        {
            Tickets = new List<Ticket>();
        }

        public int GameID { get; set; }

        public DateTime Date { get; set; }

        public string Opponent { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public bool IsActive { get; set; }

        public int SportID { get; set; }

        public virtual Sport Sport { get; set; }

    }
    public class Ticket
    {
        public int TicketID { get; set; }

        public int GameID { get; set; }

        public string UserID { get; set; }

        public bool IsAvailable { get; set; }

        public bool Visible { get; set; }

    }
    public class User
    {
        public User()
        {
            Tickets = new List<Ticket>();
        }

        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string NUID { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsSeller { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

    }

    public class BrteDBContext : DbContext
{
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }

}
}