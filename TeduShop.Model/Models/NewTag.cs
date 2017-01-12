using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("NewTags")]
    public class NewTag
    {
        [Key]
        [Column(Order=1)]
        public int NewID { set; get; }

        [ForeignKey("NewID")]
        public virtual New News { set; get; }

        [Key]
        [Column(TypeName ="varchar", Order =2)]
        [MaxLength(50)]
        public string TagsID { set; get; }

        [ForeignKey("TagsID")]
        public virtual Tag Tags { set; get; }
    }
}