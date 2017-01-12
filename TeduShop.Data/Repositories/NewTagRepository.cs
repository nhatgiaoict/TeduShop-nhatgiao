using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface INewTagRepository
    {
    }

    public class NewTagRepository : RepositoryBase<NewTag>, INewTagRepository
    {
        public NewTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}