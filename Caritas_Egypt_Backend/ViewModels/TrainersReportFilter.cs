using System;
using System.ComponentModel.DataAnnotations;

namespace Caritas_Egypt_Backend.ViewModels
{
    public class TrainersReportFilter
    {
        [Display(Name = "من تاريخ")]
        public DateTime? FromDate { get; set; }
        [Display(Name = "إلي تاريخ")]
        public DateTime? ToDate { get; set; }
        [Display(Name = "اسم المدرب")]
        public Guid? TrainerID { get; set; }
        [Display(Name = "اسم الخدمة")]
        public Guid? ServiceID { get; set; }
        [Display(Name = "اسم الفرع")]
        public Guid? BranchID { get; set; }
        [Display(Name = "من سن")]
        public int? FromAge { get; set; }
        [Display(Name = "إلي سن")]
        public int? ToAge { get; set; }

    }
}
