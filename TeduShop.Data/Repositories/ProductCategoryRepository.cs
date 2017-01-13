using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProductCategoriesRepository : IRepository<ProductCategories>
    {
        IEnumerable<ProductCategories> GetByShortLink(string shortlink);
    }

    public class ProductCategoriesRepository : RepositoryBase<ProductCategories>, IProductCategoriesRepository
    {
        public ProductCategoriesRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategories> GetByShortLink(string shortlink)
        {
            return this.DbContext.ProductCategories.Where(x => x.ShortLink == shortlink);
        }
    }
}