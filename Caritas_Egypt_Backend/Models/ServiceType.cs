using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Caritas_Egypt_Backend.Models
{
    [Table("ServiceType")]
    public class ServiceType
    {
        public ServiceType()
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
    }
}
