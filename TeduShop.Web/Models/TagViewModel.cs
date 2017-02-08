using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class TagViewModel
    {
        public string ID { set; get; }

        public string Title { set; get; }

        public string Type { set; get; }

        public virtual IEnumerable<NewsTagViewModel> NewTags { set; get; }

    }
}