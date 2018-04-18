using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSale { get; set; }
        public string TipoVenda { get; set; }
        [Required]
        public string DataVenda { get; set; }
        public int IdClient { get; set; }
        [Required]
        public int IdContribuitor { get; set; }

    }
}
