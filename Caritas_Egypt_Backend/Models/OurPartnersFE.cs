using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using iTextSharp.text.pdf.qrcode;

namespace Caritas_Egypt_Backend.Models
{
    public class OurPartnersFE
    {
        public OurPartnersFE()
        {
            Id = Guid.NewGuid();

        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Tittle")]
        public string Tittle { get; set; }
        [StringLength(5000)]
        [Display(Name = "Descreption")]
        public string Descreption { get; set; }
        public string img { get; set; }

    }
}
