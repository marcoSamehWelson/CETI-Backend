using System.ComponentModel.DataAnnotations;
using System;

namespace Caritas_Egypt_Backend.Models
{
    public class DiscriptionList
    {
        public DiscriptionList()
        {
            Id = Guid.NewGuid();

        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
