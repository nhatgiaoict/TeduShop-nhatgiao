using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("News")]
    public class New : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        [Required]
        public string Title { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        [Required]
        public string ShortLink { set; get; }

        [Required]
        public int CategoryID { set; get; }

        [ForeignKey("CategoryID")]
        public virtual NewCategory NewCategories { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(500)]
        public string Fimages { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string Summary { set; get; }

        public string Content { set; get; }

        public virtual IEnumerable<NewTag> NewTags { set; get; }
    }
}