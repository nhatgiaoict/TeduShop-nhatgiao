using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page : Auditable
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

        [Column(TypeName = "nvarchar")]
        [Required]
        public string Content { set; get; }

    }
}