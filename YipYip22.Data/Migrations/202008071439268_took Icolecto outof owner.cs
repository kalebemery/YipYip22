namespace YipYip22.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tookIcolectooutofowner : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attraction", "Owner_OwnerId", "dbo.Owner");
            DropIndex("dbo.Attraction", new[] { "Owner_OwnerId" });
            DropColumn("dbo.Attraction", "Owner_OwnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attraction", "Owner_OwnerId", c => c.Int());
            CreateIndex("dbo.Attraction", "Owner_OwnerId");
            AddForeignKey("dbo.Attraction", "Owner_OwnerId", "dbo.Owner", "OwnerId");
        }
    }
}
