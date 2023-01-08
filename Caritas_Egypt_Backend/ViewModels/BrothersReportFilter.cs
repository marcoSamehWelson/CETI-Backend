using System;

namespace Caritas_Egypt_Backend.ViewModels
{
    public class BrothersReportFilter
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public Guid? TypeOfDisabilityID { get; set; }
        public Guid? BranchID { get; set; }
        public int? FromAge { get; set; }
        public int? ToAge { get; set; }

    }
}
