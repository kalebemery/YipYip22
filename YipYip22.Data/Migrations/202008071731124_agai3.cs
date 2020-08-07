namespace YipYip22.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agai3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attraction", "Property_PropertyId", "dbo.Property");
            DropIndex("dbo.Attraction", new[] { "Property_PropertyId" });
            DropColumn("dbo.Attraction", "Property_PropertyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attraction", "Property_PropertyId", c => c.Int());
            CreateIndex("dbo.Attraction", "Property_PropertyId");
            AddForeignKey("dbo.Attraction", "Property_PropertyId", "dbo.Property", "PropertyId");
        }
    }
}
