using System.ComponentModel.DataAnnotations;

namespace DAL.ModelView
{
    public class SectorModelView
    {

        public string Nome { get; set; }
        [Required]
        public int NivelAcesso { get; set; }

    }
}
