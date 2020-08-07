namespace YipYip22.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class again : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attraction", "Owner_OwnerId", c => c.Int());
            CreateIndex("dbo.Attraction", "Owner_OwnerId");
            AddForeignKey("dbo.Attraction", "Owner_OwnerId", "dbo.Owner", "OwnerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attraction", "Owner_OwnerId", "dbo.Owner");
            DropIndex("dbo.Attraction", new[] { "Owner_OwnerId" });
            DropColumn("dbo.Attraction", "Owner_OwnerId");
        }
    }
}
