using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;
using System.Linq;

namespace TeduShop.Data.Repositories
{
    public interface INewsRepository : IRepository<News>
    {
        IEnumerable<News> GetAllByTag(string tag, int page, int pagesize, out int totalRow);
    }

    public class NewsRepository : RepositoryBase<News>, INewsRepository
    {
        public NewsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<News> GetAllByTag(string tag, int page, int pagesize, out int totalRow)
        {
            var query = from p in DbContext.News
                        join pt in DbContext.NewTags
                        on p.ID equals pt.NewID
                        where pt.TagsID == tag && p.Status
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((page - 1) * pagesize).Take(pagesize);
            return query;
        }
    }
}