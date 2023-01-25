using Caritas_Egypt_Backend.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Caritas_Egypt_Backend.Models
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Display(Name = "البريد الالكتروني")]
        public string Email { get; set; }
        [Display(Name = "الاسم")]
        public string Name { get; set; }
        [Display(Name = "نوع المستخدم")]
        public UserType UserTypeId { get; set; }

        [Display(Name = "هل المستخدم متفاعل؟")]
        public bool IsActive { get; set; }
        [Display(Name = "هل المستخدم مثبت؟")]
        public bool IsVerified { get; set; }
        [Display(Name = "تغيير كلمة السر؟")]
        public bool ChangePassword { get; set; }
        [Display(Name = "تفاصيل اخرى")]
        public string ExtraDetails { get; set; }
        [Display(Name = "كلمة السر")]
        public string TempPassword { get; set; }
        [Display(Name = "اخر وقت تم تغيير كلمة السر؟")]
        public DateTime? LastPasswordChage { get; set; }
        [Display(Name = "اخر تغيير كلمة السر تم بواسطة")]

        public Guid? LastPasswordChangeBy { get; set; }

    }
}
