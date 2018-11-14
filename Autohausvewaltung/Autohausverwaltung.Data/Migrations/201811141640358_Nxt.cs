namespace Autohausverwaltung.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nxt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.String(),
                        Model = c.String(),
                        RegisterDate = c.DateTime(nullable: false),
                        TuvUntil = c.DateTime(nullable: false),
                        Color = c.String(),
                        Price = c.Double(nullable: false),
                        CostumerId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DbSeal",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CarId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        SealDate = c.DateTime(nullable: false),
                        CostumerId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Costumers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        FirstName = c.String(),
                        TelefonNr = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Costumers");
            DropTable("dbo.Users");
            DropTable("dbo.DbSeal");
            DropTable("dbo.Cars");
        }
    }
}
