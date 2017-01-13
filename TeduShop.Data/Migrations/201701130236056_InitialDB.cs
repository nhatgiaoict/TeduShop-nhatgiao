namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 250, unicode: false),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MenuGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        URL = c.String(nullable: false, maxLength: 500),
                        Idx = c.Int(),
                        GroupID = c.Int(nullable: false),
                        Target = c.String(maxLength: 10, unicode: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MenuGroups", t => t.GroupID, cascadeDelete: true)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.NewCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        ShortLink = c.String(nullable: false, maxLength: 250, unicode: false),
                        ParentID = c.Int(),
                        Idx = c.Int(),
                        Fimages = c.String(maxLength: 500),
                        Summary = c.String(maxLength: 250),
                        HomeFlag = c.Boolean(),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        Createdby = c.String(maxLength: 50, unicode: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 50, unicode: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        ShortLink = c.String(nullable: false, maxLength: 250, unicode: false),
                        CategoryID = c.Int(nullable: false),
                        Fimages = c.String(maxLength: 500),
                        Summary = c.String(maxLength: 250),
                        Content = c.String(),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        Createdby = c.String(maxLength: 50, unicode: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 50, unicode: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.NewCategories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.NewTags",
                c => new
                    {
                        NewID = c.Int(nullable: false),
                        TagsID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.NewID, t.TagsID })
                .ForeignKey("dbo.News", t => t.NewID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagsID, cascadeDelete: true)
                .Index(t => t.NewID)
                .Index(t => t.TagsID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Title = c.String(maxLength: 50),
                        Type = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 100),
                        CustomerAddress = c.String(nullable: false, maxLength: 100),
                        CustomerEmail = c.String(nullable: false, maxLength: 50, unicode: false),
                        CustomerMobile = c.String(nullable: false, maxLength: 50, unicode: false),
                        CustomerMessage = c.String(maxLength: 250),
                        PaymentMethod = c.String(nullable: false, maxLength: 250),
                        PaymentStatus = c.String(nullable: false, maxLength: 50, unicode: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        ShortLink = c.String(nullable: false, maxLength: 250, unicode: false),
                        CategoryID = c.Int(nullable: false),
                        Fimages = c.String(maxLength: 500),
                        MoreImages = c.String(storeType: "xml"),
                        Price = c.Decimal(precision: 18, scale: 2),
                        PromotionPrice = c.Decimal(precision: 18, scale: 2),
                        Warranty = c.Int(),
                        Summary = c.String(maxLength: 250),
                        Content = c.String(nullable: false),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        Createdby = c.String(maxLength: 50, unicode: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 50, unicode: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProductCategories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        ShortLink = c.String(nullable: false, maxLength: 250, unicode: false),
                        ParentID = c.Int(),
                        Idx = c.Int(),
                        Fimages = c.String(maxLength: 500),
                        Summary = c.String(maxLength: 250),
                        HomeFlag = c.Boolean(),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        Createdby = c.String(maxLength: 50, unicode: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 50, unicode: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        ShortLink = c.String(nullable: false, maxLength: 250, unicode: false),
                        Content = c.String(nullable: false, maxLength: 4000),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        Createdby = c.String(maxLength: 50, unicode: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 50, unicode: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductTags",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.ProductID, t.TagID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Summary = c.String(maxLength: 250),
                        Fimages = c.String(nullable: false, maxLength: 500),
                        URL = c.String(nullable: false, maxLength: 250, unicode: false),
                        Idx = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SupportOnlines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Department = c.String(maxLength: 250),
                        Skype = c.String(maxLength: 250),
                        Facebook = c.String(maxLength: 250),
                        Mobile = c.String(maxLength: 250),
                        Email = c.String(maxLength: 250),
                        Yahoo = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50, unicode: false),
                        ValueString = c.String(maxLength: 250),
                        ValueInt = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VisitedDate = c.DateTime(nullable: false),
                        IPAddress = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.ProductTags", "ProductID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.ProductCategories");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.NewTags", "TagsID", "dbo.Tags");
            DropForeignKey("dbo.NewTags", "NewID", "dbo.News");
            DropForeignKey("dbo.News", "CategoryID", "dbo.NewCategories");
            DropForeignKey("dbo.Menus", "GroupID", "dbo.MenuGroups");
            DropIndex("dbo.ProductTags", new[] { "TagID" });
            DropIndex("dbo.ProductTags", new[] { "ProductID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.NewTags", new[] { "TagsID" });
            DropIndex("dbo.NewTags", new[] { "NewID" });
            DropIndex("dbo.News", new[] { "CategoryID" });
            DropIndex("dbo.Menus", new[] { "GroupID" });
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.SupportOnlines");
            DropTable("dbo.Slides");
            DropTable("dbo.ProductTags");
            DropTable("dbo.Pages");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Tags");
            DropTable("dbo.NewTags");
            DropTable("dbo.News");
            DropTable("dbo.NewCategories");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Footers");
        }
    }
}
