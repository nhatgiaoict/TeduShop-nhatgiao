using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class ProductCategoryViewModel
    {
        public int ID { set; get; }

        [Required(ErrorMessage ="Yêu cầu nhập tên danh mục")]
        public string Title { set; get; }

        [Required(ErrorMessage = "Yêu cầu nhập shortlink")]
        public string ShortLink { set; get; }

        public int? ParentID { set; get; }

        [Required(ErrorMessage = "Yêu cầu nhập số thứ tự")]
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

        [Required(ErrorMessage = "Yêu cầu nhập trạng thái")]
        public bool Status { set; get; }

        public virtual IEnumerable<ProductViewModel> News { set; get; }
    }
}