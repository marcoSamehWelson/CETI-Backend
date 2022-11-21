using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Caritas_Egypt_Backend.Models
{
    [Table("Trainer")]
    public class Trainer
    {

        public Trainer()
        {
            Id = Guid.NewGuid();
            Services = new HashSet<Service>();
            Branchs = new HashSet<Branch>();
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
        [Display(Name = "رقم التليفون ")]

        public int PhoneNumber { get; set; }
        [Display(Name = "الرقم القومى")]
        public Int16 NationalID { get; set; }
        [Display(Name = "هل يقدم خدمات مسائيه؟  ")]

        public bool NightTrainer { get; set; }
        [Display(Name = "الفرع ")]

        public Guid BranchId { get; set; }
        [Display(Name = "اسماء الخدمات التى يقدمها ")]

        public Guid ServiceId { get; set; }
       
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Branch> Branchs { get; set; }

    }
}
