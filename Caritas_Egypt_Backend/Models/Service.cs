using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Caritas_Egypt_Backend.Models
{
    [Table("Service")]
    public class Service
    {
        public Service()
        {
            Id = Guid.NewGuid();
         
        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "الاسم")]
        public string Name { get; set; }
        [Display(Name = "قيمة المكافاة للاخصائيين بالقطعة")]
        public string TrainerInsentive { get; set; }
        [Display(Name = "قيمة المكافاة للاخصائيين العاملين بالمركز خدمة")]
        public string NightTrainerInsentive { get; set; }
        public Guid ServiceTypeId { get; set; }
        public ServiceType servicesType { get; set; }

        public Guid languageId { get; set; }
        public Language language { get; set; }

        public Guid SessionTimeId { get; set; }
        public SessionTime sessionTime { get; set; }


    }
}