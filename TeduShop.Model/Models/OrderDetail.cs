using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Orders { set; get; }

        [Key]
        public int ProuctID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }

        [Required]
        public int Quantity { set; get; }
    }
}