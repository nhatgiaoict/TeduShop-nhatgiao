using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Title { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Type { set; get; }

        public virtual IEnumerable<NewsTag> NewTags { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}