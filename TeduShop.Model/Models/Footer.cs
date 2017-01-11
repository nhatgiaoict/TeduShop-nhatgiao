using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        public string ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}