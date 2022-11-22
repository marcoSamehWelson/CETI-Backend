using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace Caritas_Egypt_Backend.Models
{
 
    public class SessionReservationcs
    {
        public SessionReservationcs()
        {
            Id = Guid.NewGuid();
        }
        [Required]
        [Key]
        public Guid Id { get; set; }

        public Guid? coursePriceId { get; set; }
        public CoursePrice coursePrice { get; set; }
        public Guid? StudentId { get; set; }
        public Student student { get; set; }
        public Guid? TrainerId { get; set; }
        public Trainer trainer { get; set; }
      public  DateTime SessionDateTime { get; set; }

    }
}
