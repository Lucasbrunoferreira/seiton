using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClient { get; set; }
        //public Boolean StatusClient { get; set; }
        public string NomeRazaoSocial { get; set; }
        [Required]
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        [Required]
        public string Cep { get; set; }
        public string Cidade { get; set; }
        [Required]
        public string Bairro { get; set; }
        public string Rua { get; set; }
        [Required]
        public int NumeroDaCasa { get; set; }
        public string PontoReferencia { get; set; }
        public string Estado { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string DataCadastro { get; set; }


    }
}
