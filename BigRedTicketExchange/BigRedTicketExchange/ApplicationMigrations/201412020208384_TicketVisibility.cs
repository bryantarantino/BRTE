namespace BigRedTicketExchange.ApplicationMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TicketVisibility : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Visible", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "Visible");
        }
    }
}
