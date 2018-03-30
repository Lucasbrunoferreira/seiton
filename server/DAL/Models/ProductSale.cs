using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class ProductSale
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProductSale { get; set; }

        [Required]
        public int IdSale { get; set; }
        [Required]
        public int IdProduct { get; set; }
        public string SaleDate { get; set; }

    }
}
