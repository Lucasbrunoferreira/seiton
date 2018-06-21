using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.ModelView
{
    public class ProductModelView
    {

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
        [Required]
        public int IdLine { get; set; }
        [Required]
        public int IdProvider { get; set; }

    }
}
