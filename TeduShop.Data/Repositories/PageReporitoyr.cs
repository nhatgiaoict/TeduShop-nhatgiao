using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageReporitoyr : RepositoryBase<Page>, IPageRepository
    {
        public PageReporitoyr(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}