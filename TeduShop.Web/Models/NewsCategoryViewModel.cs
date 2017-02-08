using System;
using System.Collections.Generic;

namespace TeduShop.Web.Models
{
    public class NewsCategoryViewModel
    {
        public int ID { set; get; }

        public string Title { set; get; }

        public string ShortLink { set; get; }

        public int? ParentID { set; get; }

        public int? Idx { set; get; }

        public string Fimages { set; get; }

        public string Summary { set; get; }

        public bool? HomeFlag { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public DateTime? CreatedDate { set; get; }

        public string Createdby { set; get; }

        public DateTime? UpdateDate { set; get; }

        public string UpdateBy { set; get; }

        public bool Status { set; get; }

        public virtual IEnumerable<NewsViewModel> News { set; get; }
    }
}