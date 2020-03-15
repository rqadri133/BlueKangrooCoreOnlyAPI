using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUserActivityExecutedTime
    {
        public Guid AppUserActivityExecutedTimeId { get; set; }
        public string AppUserActivityId { get; set; }
        public DateTime AppUserActivityStartDate { get; set; }
        public DateTime AppUserActivityEndDate { get; set; }
        public DateTime ActivityStoppedOrInterrupted { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
