using System.ComponentModel.DataAnnotations;

namespace DAL.ModelView
{
    public class SaleModelView
    {
        public string TipoVenda { get; set; }
        [Required]
        public string DataVenda { get; set; }
        public int IdClient { get; set; }
        [Required]
        public int IdContribuitor { get; set; }

    }
}
