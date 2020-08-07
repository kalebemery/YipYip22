namespace YipYip22.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Owner", "ProfileId", "dbo.Profile");
            DropIndex("dbo.Owner", new[] { "ProfileId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Owner", "ProfileId");
            AddForeignKey("dbo.Owner", "ProfileId", "dbo.Profile", "ProfileId", cascadeDelete: true);
        }
    }
}
