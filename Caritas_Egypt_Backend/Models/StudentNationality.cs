using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Caritas_Egypt_Backend.Models
{
    public class StudentNationality
    {
        public StudentNationality()
        {
            Id = Guid.NewGuid();
        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "جنسية الطالب")]
        public string Name { get; set; }
    }
}
