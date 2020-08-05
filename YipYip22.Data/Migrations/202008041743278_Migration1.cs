namespace YipYip22.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attraction",
                c => new
                    {
                        AttractionId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        AttractionRating = c.Int(nullable: false),
                        AttractionLocation = c.Int(nullable: false),
                        Property_PropertyId = c.Int(),
                    })
                .PrimaryKey(t => t.AttractionId)
                .ForeignKey("dbo.Property", t => t.Property_PropertyId)
                .Index(t => t.Property_PropertyId);
            
            CreateTable(
                "dbo.Owner",
                c => new
                    {
                        OwnerId = c.Int(nullable: false, identity: true),
                        Id = c.Guid(nullable: false),
                        ProfileName = c.String(nullable: false),
                        Phone = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Rating = c.Int(),
                        Created = c.DateTime(nullable: false),
                        ProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OwnerId)
                .ForeignKey("dbo.Profile", t => t.ProfileId, cascadeDelete: true)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.Property",
                c => new
                    {
                        PropertyId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        NumOfBeds = c.Int(nullable: false),
                        Desc = c.String(nullable: false),
                        WeekdayRate = c.Double(nullable: false),
                        WeekendRate = c.Double(nullable: false),
                        Rating = c.Int(nullable: false),
                        PropertyLocation = c.Int(nullable: false),
                        OwnerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PropertyId)
                .ForeignKey("dbo.Owner", t => t.OwnerId, cascadeDelete: true)
                .Index(t => t.OwnerId);
            
            AddColumn("dbo.Profile", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Profile", "Phone", c => c.Int(nullable: false));
            DropColumn("dbo.Profile", "OwnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Profile", "OwnerId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Owner", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.Property", "OwnerId", "dbo.Owner");
            DropForeignKey("dbo.Attraction", "Property_PropertyId", "dbo.Property");
            DropIndex("dbo.Property", new[] { "OwnerId" });
            DropIndex("dbo.Owner", new[] { "ProfileId" });
            DropIndex("dbo.Attraction", new[] { "Property_PropertyId" });
            AlterColumn("dbo.Profile", "Phone", c => c.Binary(nullable: false, maxLength: 9));
            DropColumn("dbo.Profile", "Id");
            DropTable("dbo.Property");
            DropTable("dbo.Owner");
            DropTable("dbo.Attraction");
        }
    }
}
