using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUserActivityFrame
    {
        public Guid AppUserActivityFrameId { get; set; }
        public string AppUserActivityId { get; set; }
        public DateTime AppUserActivityFrameStartDate { get; set; }
        public DateTime AppUserActivityFrameEndDate { get; set; }
        public int AppUserActivityFrameSpeedDefined { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
