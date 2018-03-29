using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Provider
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProvider { get; set; }
        public long Cnpj { get; set; }
        [Required]
        public string Cidade { get; set; }
        public string Responsavel { get; set; }
        [Required]
        public long Telefone { get; set; }
        [Required]
        public string Email { get; set; }

    }
}
