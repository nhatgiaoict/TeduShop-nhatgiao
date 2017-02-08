using System;
using System.Collections.Generic;

namespace TeduShop.Web.Models
{
    public class NewsViewModel
    {
        public int ID { set; get; }

        public string Title { set; get; }

        public string ShortLink { set; get; }

        public int CategoryID { set; get; }

        public string Fimages { set; get; }

        public string Summary { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get; }  

        public int? ViewCount { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public DateTime? CreatedDate { set; get; }

        public string Createdby { set; get; }

        public DateTime? UpdateDate { set; get; }

        public string UpdateBy { set; get; }

        public bool Status { set; get; }

        public virtual IEnumerable<NewsTagViewModel> NewsTags { set; get; }

        public virtual NewsCategoryViewModel NewsCategories { set; get; }
    }
}