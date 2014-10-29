namespace BigRedTicketExchange.ApplicationMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BigRedTicketExchange.Models;
    using MySql.Data.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<BigRedTicketExchange.Models.BrteDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"ApplicationMigrations";
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
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
            if (!context.Sports.Where(x => x.Name == "Football").Any())
            {
                context.Sports.AddOrUpdate(
                new Sport { Name = "Football" }
                );
                context.SaveChanges();
                context.Games.AddOrUpdate(
                    new Game { Opponent = "Rutgers", Date = new DateTime(2014, 10, 25, 11, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Football").Single(), },
                    new Game { Opponent = "Florida Atlantic", Date = new DateTime(2014, 8, 30, 14, 30, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Football").Single() },
                    new Game { Opponent = "McNeese State", Date = new DateTime(2014, 9, 6, 14, 30, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Football").Single() },
                    new Game { Opponent = "Fresno State", Date = new DateTime(2014, 9, 13, 21, 30, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Football").Single() },
                    new Game { Opponent = "Miami", Date = new DateTime(2014, 9, 20, 19, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Football").Single() },
                    new Game { Opponent = "Illinios", Date = new DateTime(2014, 9, 26, 20, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Football").Single() },
                    new Game { Opponent = "Purdue", Date = new DateTime(2014, 11, 1, 14, 30, 0), IsActive = true, Sport = context.Sports.Where(x => x.Name == "Football").Single() },
                    new Game { Opponent = "Minnesota", Date = new DateTime(2014, 11, 22), IsActive = true, Sport = context.Sports.Where(x => x.Name == "Football").Single() }
                    );
                context.SaveChanges();

            }
            //Already Added Volleyball and Basketball
            if(!context.Sports.Where(x => x.Name == "Volleyball").Any())
            {
                context.Sports.AddOrUpdate(
                    new Sport { Name = "Volleyball"}
                    );
                context.SaveChanges();
                context.Games.AddOrUpdate(
                    new Game { Opponent = "Florida State", Date = new DateTime(2014, 8, 29, 19, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() },
                    new Game { Opponent = "Stanford", Date = new DateTime(2014, 8, 31, 12, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() },
                    new Game { Opponent = "Creighton", Date = new DateTime(2014, 9, 17, 19, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() },
                    new Game { Opponent = "Texas", Date = new DateTime(2014, 9, 20, 14, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() },
                    new Game { Opponent = "Iowa", Date = new DateTime(2014, 9, 24, 19, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() },
                    new Game { Opponent = "Penn State", Date = new DateTime(2014, 10, 3, 19, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() },
                    new Game { Opponent = "Ohio State", Date = new DateTime(2014, 10, 4, 17, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() },
                    new Game { Opponent = "Northwestern", Date = new DateTime(2014, 10, 15, 19, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() },
                    new Game { Opponent = "Illinois", Date = new DateTime(2014, 10, 18, 15, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() },
                    new Game { Opponent = "Purdue", Date = new DateTime(2014, 11, 5, 18, 30, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() },
                    new Game { Opponent = "Indiana", Date = new DateTime(2014, 11, 8, 19, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() },
                    new Game { Opponent = "Michigan State", Date = new DateTime(2014, 11, 12, 19, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() },
                    new Game { Opponent = "Maryland", Date = new DateTime(2014, 11, 16, 14, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() },
                    new Game { Opponent = "Michigan", Date = new DateTime(2014, 11, 22, 19, 0, 0), IsActive = false, Sport = context.Sports.Where(x => x.Name == "Volleyball").Single() }
                    );
            }
        }
    }
}
