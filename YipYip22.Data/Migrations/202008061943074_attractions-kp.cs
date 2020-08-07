namespace YipYip22.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class attractionskp : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attraction", "Property_PropertyId", "dbo.Property");
            DropIndex("dbo.Attraction", new[] { "Property_PropertyId" });
            AddColumn("dbo.Property", "AttractionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Property", "AttractionId");
            AddForeignKey("dbo.Property", "AttractionId", "dbo.Attraction", "AttractionId", cascadeDelete: true);
            DropColumn("dbo.Attraction", "Property_PropertyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attraction", "Property_PropertyId", c => c.Int());
            DropForeignKey("dbo.Property", "AttractionId", "dbo.Attraction");
            DropIndex("dbo.Property", new[] { "AttractionId" });
            DropColumn("dbo.Property", "AttractionId");
            CreateIndex("dbo.Attraction", "Property_PropertyId");
            AddForeignKey("dbo.Attraction", "Property_PropertyId", "dbo.Property", "PropertyId");
        }
    }
}
