using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(100)]
        [Required]
        public string CustomerName { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(100)]
        [Required]
        public string CustomerAddress { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public string CustomerEmail { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public string CustomerMobile { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string CustomerMessage { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        [Required]
        public string PaymentMethod { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public string PaymentStatus { set; get; }

        [Required]
        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}