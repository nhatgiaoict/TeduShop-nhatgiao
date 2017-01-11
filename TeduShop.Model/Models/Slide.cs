using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required]
        public string Title { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string Summary { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(500)]
        [Required]
        public string Fimages { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        [Required]
        public string URL { set; get; }

        public int? Idx { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}