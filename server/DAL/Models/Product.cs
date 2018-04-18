using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduct{ get; set; }
        public Boolean StatusProduct { get; set; }
        public long CodigoBarra { get; set; }
        [Required]
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public string Lote { get; set; }
        [Required]
        public string DataValidade { get; set; }
        public string DataCadastro { get; set; }
        [Required]
        public string DataEntrada { get; set; }
        public double PrecoCompra { get; set; }
        [Required]
        public double PrecoVenda { get; set; }
        public decimal Desconto { get; set; }
        public decimal Icms { get; set; }
        [Required]
        public int IdLine { get; set; }
        [Required]
        public int IdProvider { get; set; }

    }
}
