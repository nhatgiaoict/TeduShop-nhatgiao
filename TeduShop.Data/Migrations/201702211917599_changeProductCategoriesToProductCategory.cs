namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeProductCategoriesToProductCategory : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductCategories", newName: "ProductCategory");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ProductCategory", newName: "ProductCategories");
        }
    }
}
