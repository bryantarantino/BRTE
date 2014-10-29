namespace BigRedTicketExchange.UserMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BigRedTicketExchange.Models;
    using MySql.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;

    internal sealed class Configuration : DbMigrationsConfiguration<BigRedTicketExchange.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"UserMigrations";
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());

        }

        protected override void Seed(BigRedTicketExchange.Models.ApplicationDbContext context)
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
            //if (!context.Users.Where(x => x.UserName == "ethan@brte.com").Any())
            //{
            //    var roleStore = new RoleStore<IdentityRole>(context);
            //    var roleManager = new RoleManager<IdentityRole>(roleStore);
            //    var userStore = new UserStore<ApplicationUser>(context);
            //    var userManager = new UserManager<ApplicationUser>(userStore);
            //    var user = new ApplicationUser { Email = "ethan@brte.com",  };
            //    context.Users.AddOrUpdate(user);
            //    context.SaveChanges();
            //    userManager.Create(user, "admin");

            //    roleManager.Create(new IdentityRole { Name = "admin" });
            //    roleManager.Create(new IdentityRole { Name = "member" });
            //    userManager.AddToRole(user.Id, "admin");
            //    context.SaveChanges();
            //}
            if (!context.Users.Where(x => x.Email == "ethan@brte.com").Any())
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var user = new ApplicationUser { Email = "ethan@brte.com", UserName = "ethan@brte.com", PasswordHash = "Abc123.", FullName = "Ethan Johnson"};
                context.Users.AddOrUpdate(user);
                //context.SaveChanges();
                userManager.Create(user, "Abc123.");

                userManager.AddToRole(user.Id, "admin");
                //context.SaveChanges();
            }
        }
    }
}
