using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface INewRepository
    {
    }
    public class NewRepository:RepositoryBase<New>, INewRepository
    {
        public NewRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }

    
}
