using System;

namespace Caritas_Egypt_Backend.ViewModels
{
    public class ServiceReportResult
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? TotalBeneficiaries { get; set; }
        public string? ServiceName { get; set; }
        public string? BranchName { get; set; }
        public int? TotalIncome { get; set; }
        public int? FromAge { get; set; }
        public int? ToAge { get; set; }
        public Guid? ServiceID { get; set; }
        public Guid? BranchID { get; set; }
        public string FullAge => string.Format("{0} - {1}", FromAge, ToAge);



    }
}
