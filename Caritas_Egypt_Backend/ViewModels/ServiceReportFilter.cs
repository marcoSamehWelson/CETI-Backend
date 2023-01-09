using System;

namespace Caritas_Egypt_Backend.ViewModels
{
    public class ServiceReportFilter
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
      
        public Guid? ServiceID { get; set; }
        public Guid? BranchID { get; set; }
        public int? FromAge { get; set; }
        public int? ToAge { get; set; }

    }
}
