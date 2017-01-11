using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        [Required]
        public string Name { set; get; }

        [Column(TypeName = "nvarchar")]
        [Required]
        public string Content { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string MetaKeyword { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string MetaDescription { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}