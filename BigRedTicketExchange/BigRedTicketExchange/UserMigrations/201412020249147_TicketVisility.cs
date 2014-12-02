namespace BigRedTicketExchange.UserMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TicketVisility : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tickets", "Visible");
            AddColumn("dbo.Tickets", "Visible", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "Visible");
        }
    }
}
