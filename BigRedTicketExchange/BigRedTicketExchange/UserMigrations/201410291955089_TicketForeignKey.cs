namespace BigRedTicketExchange.UserMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TicketForeignKey : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tickets", "UserID", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tickets", "UserID", c => c.Int(nullable: false));
        }
    }
}
