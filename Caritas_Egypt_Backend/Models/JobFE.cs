﻿using System.ComponentModel.DataAnnotations;
using System;
using System.Xml.Linq;
using System.Collections.Generic;
using iTextSharp.text.pdf.qrcode;

namespace Caritas_Egypt_Backend.Models
{
    public class JobFE
    {
        public JobFE()
        {
            Id = Guid.NewGuid();

        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "العنوان")]
        public string Tittle { get; set; }
        [StringLength(5000)]
        [Display(Name = "الوصف")]
        public string Descreption { get; set; }
        [Display(Name = "الصورة")]
        public string img { get; set; }
		[Display(Name = "تسلسل")]

		public int serial { get; set; }
	}
}
