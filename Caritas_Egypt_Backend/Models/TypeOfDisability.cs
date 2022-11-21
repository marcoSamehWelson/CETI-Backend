using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Caritas_Egypt_Backend.Models
{
    [Table("TypeOfDisability")]
    public class TypeOfDisability
    {
        public TypeOfDisability()
        {
            Id = Guid.NewGuid();
        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "TypeOfDisability")]
        public string Name { get; set; }

      
    }
}
 