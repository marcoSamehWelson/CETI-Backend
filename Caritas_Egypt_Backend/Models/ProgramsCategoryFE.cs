using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using iTextSharp.text.pdf.qrcode;

namespace Caritas_Egypt_Backend.Models
{
    public class ProgramsCategoryFE
    {
        public ProgramsCategoryFE()
        {
            Id = Guid.NewGuid();

        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(1000)]
        [Display(Name = "العنوان")]
        public string Tittle { get; set; }
        [StringLength(50000)]
        [Display(Name = "الوصف")]
        public string Descreption { get; set; }
        [Display(Name = "الصورة")]
        public string img { get; set; }

    }
}
