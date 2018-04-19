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
        [Required]
        public long CodigoBarra { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required] 
        public int Estoque { get; set; }
        [Required]
        public string Lote { get; set; }
        public string DataValidade { get; set; }
        public string DataCadastro { get; set; }
        public string DataEntrada { get; set; }
        [Required]
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
