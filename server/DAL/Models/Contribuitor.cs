using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Contribuitor
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdContribuitor { get; set; }
        //public Boolean StatusContribuitor { get; set; }
        public string Nome { get; set; }
        [Required]
        public string Usuario { get; set; }
        public string Senha { get; set; }
        [Required]
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        [Required]
        public string DataCadastro { get; set; }
        [Required]
        public int IdSector { get;set; }

    }
}
