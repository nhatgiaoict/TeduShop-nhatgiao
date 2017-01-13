using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface INewsCategoryRepository : IRepository<NewsCategory>
    {
    }

    public class NewsCategoryRepository : RepositoryBase<NewsCategory>, INewsCategoryRepository
    {
        public NewsCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}