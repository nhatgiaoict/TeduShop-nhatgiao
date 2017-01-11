﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategories : Auditable
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

        public int? ParentID { set; get; }

        public int? Idx { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(500)]
        public string Fimages { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string Summary { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}