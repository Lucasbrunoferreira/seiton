using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    [Table("Line")]
    public class Line
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLine { get; set; }
        [Required]
        public string Nome { get; set; }

        public ICollection<Product> Products { get; set; }


    }
}
