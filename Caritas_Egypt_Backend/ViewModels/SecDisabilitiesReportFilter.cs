﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Caritas_Egypt_Backend.ViewModels
{
    public class SecDisabilitiesReportFilter
    {
        [Display(Name = "من تاريخ")]
        public DateTime? FromDate { get; set; }
        [Display(Name = "إلي تاريخ")]
        public DateTime? ToDate { get; set; }
        [Display(Name = "نوع الإعاقة")]
        public Guid? TypeOfDisabilityID { get; set; }
        [Display(Name = "اسم الفرع")]
        public Guid? BranchID { get; set; }
        [Display(Name = "هل ملتحق بمدرسة؟")]
        public bool InSchool { get; set; }
        [Display(Name = "من سن")]
        public int? FromAge { get; set; }
        [Display(Name = "إلي سن")]
        public int? ToAge { get; set; }

    }
}
