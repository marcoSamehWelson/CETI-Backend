using System;
using System.ComponentModel.DataAnnotations;

namespace Caritas_Egypt_Backend.ViewModels
{
    public class SecTrainersReportFilter
    {
        [Display(Name = "من تاريخ")]
        public DateTime? FromDate { get; set; }
        [Display(Name = "إلي تاريخ")]
        public DateTime? ToDate { get; set; }
        [Display(Name = "اسم المدرب")]
        public Guid? TrainerID { get; set; }
        [Display(Name = "اسم الفرع")]
        public Guid? BranchID { get; set; }

    }
}
