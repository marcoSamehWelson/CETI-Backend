using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using iTextSharp.text.pdf.qrcode;

namespace Caritas_Egypt_Backend.Models
{
    public class ProgramsFE
    {
        public ProgramsFE()
        {
            Id = Guid.NewGuid();

        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "عنوان")]
        public string Tittle { get; set; }
        [StringLength(500)]
        [Display(Name = "Descreption")]
        public string Descreption { get; set; }
        [Display(Name = "img")]
        public string img { get; set; }
     


        public Guid? ProgramsCategoryFEId { get; set; }
        public ProgramsCategoryFE programsCategoryFE { get; set; }
    }
}
