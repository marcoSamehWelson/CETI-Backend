using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace Caritas_Egypt_Backend.Models
{
 
    public class SessionReservations
    {
        public SessionReservations()
        {
            Id = Guid.NewGuid();
        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Display(Name = "سعر الدوره")]
        public Guid? coursePriceId { get; set; }
        [Display(Name = "سعر الدوره")]
        public CoursePrice coursePrice { get; set; }
        [Display(Name = "اسم الطالب")]
        public int? StudentId { get; set; }
        [Display(Name = "اسم الطالب")]
        public Student student { get; set; }
        [Display(Name = "اسم المدرب")]
        public Guid? TrainerId { get; set; }
        [Display(Name = "اسم المدرب")]
        public Trainer trainer { get; set; }
        [Display(Name = "موعد الجلسة")]
        public DateTime SessionDateTime { get; set; }
        [Display(Name = "هل حضر الطالب")]
        public bool InAttend { get; set; }
        [Display(Name = "هل غاب الطالب")]
        public bool InAbsence { get; set; }

    }
}
