using System;

namespace Caritas_Egypt_Backend.ViewModels
{
    public class SecTrainersReportFilter
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public Guid? TrainerID { get; set; }
        public Guid? BranchID { get; set; }

    }
}
