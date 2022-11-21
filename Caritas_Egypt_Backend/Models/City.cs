using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Caritas_Egypt_Backend.Models
{
    [Table("City")]
    public class City
    {
        public City()
        {
            Id = Guid.NewGuid();
            governorate = new HashSet<Governorate>();
        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "الاسم")]
        public string Name { get; set; }
        public Guid GovernorateId { get; set; }

        public virtual ICollection<Governorate> governorate { get; set; }

    }
}
