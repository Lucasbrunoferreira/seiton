using System.ComponentModel.DataAnnotations;

namespace DAL.ModelView
{
    public class ProviderModelView
    {

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
