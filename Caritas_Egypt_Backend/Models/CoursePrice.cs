using System;
using System.ComponentModel.DataAnnotations;

namespace Caritas_Egypt_Backend.Models
{
    public class CoursePrice
    {
        public CoursePrice()
        {
            Id = Guid.NewGuid();
        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        //Added By Peter
        public Guid? ServiceId { get; set; }
        public Service service { get; set; }
        public Guid? StudentNationalityId { get; set; }
        public StudentNationality studentNationality { get; set; }
        public Guid? BranchId { get; set; }
        public Branch branch { get; set; }
        [Display(Name = "السعر")]
        public string Price { get; set; }

    }
}
