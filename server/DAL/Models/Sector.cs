using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Sector
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSector { get; set; }
        public string Nome { get; set; }
        [Required]
        public int NivelAcesso { get; set; }
        
    }
}
