using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Caritas_Egypt_Backend.Models
{
    [Table("StudentParent")]
    public class StudentParent
    {
         public  StudentParent()
        {
            Id = Guid.NewGuid();
        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "الاسم الاول")]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Display(Name = "الاسم الثانى")]
        public string SecondName { get; set; }
        [StringLength(50)]
        [Display(Name = "الاسم الثالث")]
        public string LastName { get; set; }
        [Display(Name = "رقم تليفون الاب")]
        
        public int PhoneNumber { get; set; }
        [Display(Name = "رقم تليفون ارضى ")]
        public int LandPhoneNumber { get; set; }
        [Display(Name = "مؤهل الاب ")]
        public string EducationQualification { get; set; }
        [Display(Name = "الوظيفة ")]
        public string JopTitle { get; set; }
        [Display(Name = "البريد الالكترونى ")]
        public int Email { get; set; }
        [Display(Name = "اسم الام الاول")]
        public string MotherFirstName { get; set; }
        [StringLength(50)]
        [Display(Name = "اسم الام الثانى")]
        public string MotherSecondName { get; set; }
        [StringLength(50)]
        [Display(Name = "اسم الام الثالث")]
        public string MotherLastName { get; set; }
        [Display(Name = "رقم تليفون الام ")]
        public string MotherPhoneNumber { get; set; }
        [Display(Name = "مؤهل الام")]
        public string MotherEducationQualification { get; set; }
        [Display(Name = "وظيفه الام")]
        public string MotherJopTitle { get; set; }
    }
}
