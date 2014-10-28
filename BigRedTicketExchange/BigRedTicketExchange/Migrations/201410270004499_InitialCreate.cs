namespace BigRedTicketExchange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Opponent = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        SportID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameID)
                .ForeignKey("dbo.Sports", t => t.SportID, cascadeDelete: true)
                .Index(t => t.SportID);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        SportID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SportID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketID = c.Int(nullable: false, identity: true),
                        GameID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TicketID)
                .ForeignKey("dbo.Games", t => t.GameID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.GameID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        IsSeller = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "UserID", "dbo.Users");
            DropForeignKey("dbo.Tickets", "GameID", "dbo.Games");
            DropForeignKey("dbo.Games", "SportID", "dbo.Sports");
            DropIndex("dbo.Tickets", new[] { "UserID" });
            DropIndex("dbo.Tickets", new[] { "GameID" });
            DropIndex("dbo.Games", new[] { "SportID" });
            DropTable("dbo.Users");
            DropTable("dbo.Tickets");
            DropTable("dbo.Sports");
            DropTable("dbo.Games");
        }
    }
}
