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
        public string Email { get; set; }
        public string Name { get; set; }
        public UserType UserTypeId { get; set; }


        public bool IsActive { get; set; }
        public bool IsVerified { get; set; }
        public bool ChangePassword { get; set; }

        public string ExtraDetails { get; set; }
        public string TempPassword { get; set; }
        public DateTime? LastPasswordChage { get; set; }
        public Guid? LastPasswordChangeBy { get; set; }

    }
}
