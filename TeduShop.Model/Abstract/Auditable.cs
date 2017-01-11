using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Abstract
{
    public class Auditable : IAuditable
    {
        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string MetaKeyword { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string MetaDescription { set; get; }

        public DateTime? CreatedDate { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Createdby { set; get; }

        public DateTime? UpdateDate { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string UpdateBy { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}