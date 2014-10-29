namespace BigRedTicketExchange.ApplicationMigrations
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
                        Date = c.DateTime(nullable: false, precision: 0),
                        Opponent = c.String(unicode: false),
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
                        Name = c.String(unicode: false),
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
                .Index(t => t.GameID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "GameID", "dbo.Games");
            DropForeignKey("dbo.Games", "SportID", "dbo.Sports");
            DropIndex("dbo.Tickets", new[] { "GameID" });
            DropIndex("dbo.Games", new[] { "SportID" });
            DropTable("dbo.Tickets");
            DropTable("dbo.Sports");
            DropTable("dbo.Games");
        }
    }
}
