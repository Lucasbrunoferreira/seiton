using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Provider
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProvider { get; set; }
        //public Boolean StatusProvider { get; set; }
        public string Cnpj { get; set; }
        [Required]
        public string Cidade { get; set; }
        public string Responsavel { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }

    }
}
