using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface INewCategoryRepository
    {
    }

    public class NewCategoryRepository : RepositoryBase<NewCategory>, INewCategoryRepository
    {
        public NewCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}