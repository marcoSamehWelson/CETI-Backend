using System;
using System.ComponentModel.DataAnnotations;


namespace Caritas_Egypt_Backend.ViewModels
{
    public class ServiceReportResult
    {
        [Display(Name = "من تاريخ")]
        public DateTime? FromDate { get; set; }
        [Display(Name = "إلي تاريخ")]
        public DateTime? ToDate { get; set; }
        [Display(Name = "عدد المستفيدين")]
        public int? TotalBeneficiaries { get; set; }
        [Display(Name = "اسم الخدمة")]
        public string? ServiceName { get; set; }
        [Display(Name = "اسم الفرع")]
        public string? BranchName { get; set; }
        [Display(Name = "مجموع الدخل")]
        public int? TotalIncome { get; set; }
        [Display(Name = "من سن")]
        public int? FromAge { get; set; }
        [Display(Name = "إلي سن")]
        public int? ToAge { get; set; }
        [Display(Name = "اسم الخدمة")]
        public Guid? ServiceID { get; set; }
        [Display(Name = "اسم الفرع")]
        public Guid? BranchID { get; set; }
        [Display(Name = "السن")]
        public string FullAge => string.Format("{0} - {1}", FromAge, ToAge);



    }
}
