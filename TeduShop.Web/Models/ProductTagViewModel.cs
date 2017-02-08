using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class ProductTagViewModel
    {
        public int ProductID { set; get; }

        public string TagsID { set; get; }

        public virtual ProductViewModel Product { set; get; }

        public virtual TagViewModel Tags { set; get; }
    }
}