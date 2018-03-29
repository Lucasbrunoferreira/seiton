using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.ModelView
{
    public class SectorModelView
    {

        public string Nome { get; set; }
        [Required]
        public int NivelAcesso { get; set; }

    }
}
