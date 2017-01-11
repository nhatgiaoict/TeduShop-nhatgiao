using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string Department { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string Skype { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string Facebook { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string Mobile { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string Email { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string Yahoo { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}