using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface INewsTagRepository : IRepository<NewsTag>
    {
    }

    public class NewsTagRepository : RepositoryBase<NewsTag>, INewsTagRepository
    {
        public NewsTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}