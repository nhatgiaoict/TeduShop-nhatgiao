namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewsDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "HomeFlag", c => c.Boolean());
            AddColumn("dbo.News", "HotFlag", c => c.Boolean());
            AddColumn("dbo.News", "ViewCount", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "ViewCount");
            DropColumn("dbo.News", "HotFlag");
            DropColumn("dbo.News", "HomeFlag");
        }
    }
}
