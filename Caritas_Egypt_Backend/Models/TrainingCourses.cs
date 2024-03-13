using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using System.Collections.Generic;

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
        [StringLength(1000)]
        [Display(Name = "العنوان")]
        public string Tittle { get; set; }
        [StringLength(50000)]
        [Display(Name = "الوصف")]
        public string Descreption { get; set; }
        [Display(Name = "الصورة")]
        public string img { get; set; }
        [Display(Name = "الفرع")]
        public Guid? branchId { get; set; }
        [Display(Name = "الفرع")]
        public Branch branch { get; set; }
        [Display(Name = "من تاريخ")]
        public DateTime StartDate { get; set; }
        [Display(Name = "إلى تاريخ")]
        public DateTime EndDate { get; set; }
        [Display(Name = "تسلسل")]

        public int serial { get; set; }

    }
}
