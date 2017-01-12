using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IVisitorStatisticsRepository
    {
    }

    public class VisitorStatisticsRepository : RepositoryBase<VisitorStatistics>, IVisitorStatisticsRepository
    {
        public VisitorStatisticsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}