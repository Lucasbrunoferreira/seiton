using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.ModelView
{
    public class ProviderModelView
    {

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
