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
        [Required]
        [StringLength(50)]
        [Display(Name = "الاسم")]
        public string Name { get; set; }
        //Added By Peter
        [Display(Name = "اسم الخدمة")]
        public Guid? ServiceId { get; set; }
        [Display(Name = "اسم الخدمة")]
        public Service service { get; set; }
        [Display(Name = "جنسية الطالب")]
        public Guid? StudentNationalityId { get; set; }
        [Display(Name = "جنسية الطالب")]
        public StudentNationality studentNationality { get; set; }
        [Display(Name = "الفرع")]
        public Guid? BranchId { get; set; }
        [Display(Name = "الفرع")]
        public Branch branch { get; set; }
        [Display(Name = "السعر")]
        public string Price { get; set; }

    }
}
