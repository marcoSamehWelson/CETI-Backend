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
        [StringLength(50)]
        [Display(Name = "عنوان")]
        public string Tittle { get; set; }
        [StringLength(5000)]
        [Display(Name = "Paragraph")]
        public string Paragraph { get; set; }
        public string Year { get; set; }
        public string Location { get; set; }
        public string Objectives { get; set; }
        [Display(Name = "Main activities")]
        public string Mainactivities { get; set; }
        public string Partners { get; set; }
        [Display(Name = "Target group/Beneficiaries")]
        public string TargetgrouporBeneficiaries { get; set; }
        public Guid? ProjectsCategoryFEId { get; set; }
        public ProjectsCategoryFE projectsCategoryFE { get; set; }
    }
}
