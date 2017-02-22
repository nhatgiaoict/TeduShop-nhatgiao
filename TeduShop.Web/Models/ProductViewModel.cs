using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class ProductViewModel
    {
        public int ID { set; get; }

        public string Title { set; get; }

        public string ShortLink { set; get; }

        public int CategoryID { set; get; }

        public virtual ProductCategoryViewModel ProductCategories { set; get; }

        public string Fimages { set; get; }

        public string MoreImages { set; get; }

        public decimal? Price { set; get; }

        public decimal? PromotionPrice { set; get; }

        public int? Warranty { set; get; }

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

        public string Tags { set; get; }

    }
}