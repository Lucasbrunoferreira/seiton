using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.ModelView
{
    public class ProductSaleModelView
    {

        [Required]
        public int IdSale { get; set; }
        public int IdProduct { get; set; }
        [Required]
        public DateTime SaleDate { get; set; }


    }
}
