using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using iTextSharp.text.pdf.qrcode;

namespace Caritas_Egypt_Backend.Models
{
    public class TrainingCourses
    {
        public TrainingCourses()
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
        [Display(Name = "branch")]
        public Guid? branchId { get; set; }
        public Branch branch { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}
