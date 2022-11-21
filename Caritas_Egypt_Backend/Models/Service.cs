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
            servicesType = new HashSet<ServiceType>();
            sessionTime = new HashSet<SessionTime>();
            language = new HashSet<Language>();
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

        public virtual ICollection<ServiceType> servicesType { get; set; }
        public Guid languageId { get; set; }

        public virtual ICollection<Language> language { get; set; }
        public Guid SessionTimeId { get; set; }

        public virtual ICollection<SessionTime> sessionTime { get; set; }

    }
}