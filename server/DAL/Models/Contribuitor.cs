using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    [Table("Contribuitor")]
    public class Contribuitor
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdContribuitor { get; set; }
        //public Boolean StatusContribuitor { get; set; }
        public string Nome { get; set; }
        [Required]
        public string Usuario { get; set; }
        [JsonIgnore]
        public string Senha { get; set; }
        [Required]
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        [Required]
        public DateTime DataCadastro { get; set; }
        [Required, ForeignKey("Sector")]
        public int IdSector { get;set; }
        [JsonIgnore]
        public virtual Sector Sector { get; set; }
        [JsonIgnore]
        public ICollection<Sale> Sales { get; set; }

    }
}
