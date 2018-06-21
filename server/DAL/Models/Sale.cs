using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    [Table("Sale")]
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSale { get; set; }
        public string TipoVenda { get; set; }
        [Required]
        public DateTime DataVenda { get; set; }

        [Required, ForeignKey("Product")]
        public int IdProduct { get; set; }

        public int Quantidade { get; set; }
        [Required, ForeignKey("Client")]
        public int IdClient { get; set; }
        public virtual Client Client { get; set; }

        [Required, ForeignKey("Contribuitor")]
        public int IdContribuitor { get; set; }
        public virtual Contribuitor Contribuitor { get; set; }

        public ICollection<ProductSale> ProductSales { get; set; }

    }
}
