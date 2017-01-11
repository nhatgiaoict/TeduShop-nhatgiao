using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        [Required]
        public string Title { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(500)]
        [Required]
        public string URL { set; get; }

        public int? Idx { set; get; }

        [Required]
        public int GroupID { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        public string Target { set; get; }

        [Required]
        public bool Status { set; get; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroups { set; get; }
    }
}