namespace BigRedTicketExchange.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MySql.Data.Entity;
    using BigRedTicketExchange.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BigRedTicketExchange.Models.BrteDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());    // This will add our MySQLClient as SQL Generator
        }

        protected override void Seed(BigRedTicketExchange.Models.BrteDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //if (!context.Sports.Where(x => x.Name == "Football").Any())
            //{
            //    context.Sports.AddOrUpdate(
            //    new Sport { Name = "Football" }
            //    );
            //    context.SaveChanges();
            //    context.Games.AddOrUpdate(
            //        new Game { Opponent="Rutgers", Date = new DateTime(2014, 10, 25), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Football").Single(), }
            //        );
            //}
            //context.Sports.AddOrUpdate(
            //    new Sport { Name = "Volleyball" },
            //    new Sport { Name = "Men's Basketball"}
            //    );
            //context.SaveChanges();
            //context.Games.AddOrUpdate(
            //    new Game { Opponent = "Florida Atlantic", Date = new DateTime(2014, 8, 30), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Football").Single() },
            //    new Game { Opponent = "McNeese State", Date = new DateTime(2014, 9, 6), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Football").Single() },
            //    new Game { Opponent = "Fresno State", Date = new DateTime(2014, 9, 13), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Football").Single() },
            //    new Game { Opponent = "Miami", Date = new DateTime(2014, 9, 20), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Football").Single() },
            //    new Game { Opponent = "Illinios", Date = new DateTime(2014, 9, 26), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Football").Single() },
            //    new Game { Opponent = "Purdue", Date = new DateTime(2014, 11, 1), IsActive = true, Sport = context.Sports.Where(x => x.Name == "Football").Single() },
            //    new Game { Opponent = "Minnesota", Date = new DateTime(2014, 11, 22), IsActive = true, Sport = context.Sports.Where(x => x.Name == "Football").Single() }
            //    );
        }
    }
}
