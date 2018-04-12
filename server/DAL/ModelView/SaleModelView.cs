using System.ComponentModel.DataAnnotations;

namespace DAL.ModelView
{
    public class SaleModelView
    {

        [Required]
        public string TipoVenda { get; set; }
        [Required]
        public string DataVenda { get; set; }
        [Required]
        public int IdClient { get; set; }
        [Required]
        public int IdContribuitor { get; set; }
        





    }
}
