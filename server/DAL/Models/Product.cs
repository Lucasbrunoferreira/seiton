using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    [Table("Product")]
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduct{ get; set; }
        public Boolean StatusProduct { get; set; }
        public string CodigoBarra { get; set; }
        [Required]
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public string Lote { get; set; }
        [Required]
        public DateTime DataValidade { get; set; }
        public DateTime DataCadastro { get; set; }
        [Required]
        public DateTime DataEntrada { get; set; }
        public float PrecoCompra { get; set; }
        [Required]
        public float PrecoVenda { get; set; }
        public float Desconto { get; set; }
        public float Icms { get; set; }
        [Required, ForeignKey("Line")]
        public int IdLine { get; set; }
        public virtual Line Line { get; set; }

        [Required, ForeignKey("Provider")]
        public int IdProvider { get; set; }
        public virtual Provider Provider { get; set; }

        public ICollection<ProductSale> ProductSales { get; set; }

        public ICollection<Sale> Sale { get; set; }

    }
}
