namespace YipYip22.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AHTusd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Booking",
                c => new
                    {
                        ProfileId = c.Int(nullable: false),
                        PropertyId = c.Int(nullable: false),
                        BookingId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        WeekendPrice = c.Double(nullable: false),
                        WeekDayPrice = c.Double(nullable: false),
                        NumOfWeekend = c.Int(),
                        NumOfWeekDay = c.Int(),
                        TotalPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProfileId)
                .ForeignKey("dbo.Profile", t => t.ProfileId)
                .ForeignKey("dbo.Property", t => t.PropertyId, cascadeDelete: true)
                .Index(t => t.ProfileId)
                .Index(t => t.PropertyId);
            
            DropColumn("dbo.Owner", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Owner", "Rating", c => c.Int());
            DropForeignKey("dbo.Booking", "PropertyId", "dbo.Property");
            DropForeignKey("dbo.Booking", "ProfileId", "dbo.Profile");
            DropIndex("dbo.Booking", new[] { "PropertyId" });
            DropIndex("dbo.Booking", new[] { "ProfileId" });
            DropTable("dbo.Booking");
        }
    }
}
