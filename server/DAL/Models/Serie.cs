using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BancoDeDados.Models
{
   public class Serie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSerie { get; set;}
        [Required]
        public string Nome { get; set; }
 
    }
}
