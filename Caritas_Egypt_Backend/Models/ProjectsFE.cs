using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace Caritas_Egypt_Backend.Models
{
    public class ProjectsFE
    {

        public ProjectsFE()
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
        public string Paragraph { get; set; }
        [Display(Name = "السنة")]
        public string Year { get; set; }
        [Display(Name = "المكان")]
        public string Location { get; set; }
        [Display(Name = "الاهداف")]
        public string Objectives { get; set; }
        [Display(Name = "Main activities")]
        public string Mainactivities { get; set; }
        public string Partners { get; set; }
        [Display(Name = "Target group/Beneficiaries")]
        public string TargetgrouporBeneficiaries { get; set; }
        [Display(Name = "فئة المشاريع")]
        public Guid? ProjectsCategoryFEId { get; set; }
        [Display(Name = "فئة المشاريع")]
        public ProjectsCategoryFE projectsCategoryFE { get; set; }
		[Display(Name = "تسلسل")]

		public int serial { get; set; }
	}
}
