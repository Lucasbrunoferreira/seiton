using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class ProductSale
    {
        [Required, ForeignKey("Sale")]
        public int IdSale { get; set; }
        
        public virtual Sale Sale { get; set; }


        [Required, ForeignKey("Product")]
        public int IdProduct { get; set; }
       
        public virtual Product Product { get; set; }

        [Required]
        public DateTime SaleDate { get; set; }

    }
}
