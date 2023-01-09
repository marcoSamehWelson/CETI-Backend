using System;

namespace Caritas_Egypt_Backend.ViewModels
{
    public class TrainersReportFilter
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public Guid? TrainerID { get; set; }

        public Guid? ServiceID { get; set; }
        public Guid? BranchID { get; set; }
        public int? FromAge { get; set; }
        public int? ToAge { get; set; }

    }
}
