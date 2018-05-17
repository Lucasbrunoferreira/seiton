using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.ModelView
{
    public class ClientModelView
    {

        //public Boolean StatusClient { get; set; }
        public string NomeRazaoSocial { get; set; }
        [Required]
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
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
        public DateTime DataCadastro { get; set; }


    }
}
