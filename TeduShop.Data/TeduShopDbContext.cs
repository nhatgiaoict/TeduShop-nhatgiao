using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TeduShop.Model.Models;

namespace TeduShop.Data
{
    public class TeduShopDbContext : IdentityDbContext<ApplicationUser>
    {
        public TeduShopDbContext() : base("TeduShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<News> News { set; get; }
        public DbSet<NewsCategory> NewCategories { set; get; }
        public DbSet<NewsTag> NewTags { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }

        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slide { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<VisitorStatistics> VisitorStatistics { set; get; }
        public DbSet<Error> Errors { set; get; }

        public static TeduShopDbContext Create()
        {
            return new TeduShopDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder buider)
        {
            buider.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            buider.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}