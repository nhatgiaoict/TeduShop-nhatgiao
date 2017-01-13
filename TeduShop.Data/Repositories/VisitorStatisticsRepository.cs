using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IVisitorStatisticsRepository : IRepository<VisitorStatistics>
    {
    }

    public class VisitorStatisticsRepository : RepositoryBase<VisitorStatistics>, IVisitorStatisticsRepository
    {
        public VisitorStatisticsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}