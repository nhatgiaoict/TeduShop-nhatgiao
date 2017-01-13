using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("NewsTags")]
    public class NewsTag
    {
        [Key]
        [Column(Order=1)]
        public int NewID { set; get; }

        [ForeignKey("NewID")]
        public virtual News News { set; get; }

        [Key]
        [Column(TypeName ="varchar", Order =2)]
        [MaxLength(50)]
        public string TagsID { set; get; }

        [ForeignKey("TagsID")]
        public virtual Tag Tags { set; get; }
    }
}