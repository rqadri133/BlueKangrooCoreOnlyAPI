using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUserActivityInput
    {
        public Guid AppUserActivityInputId { get; set; }
        public string AppUserActivityInputName { get; set; }
        public string AppUserActivityInputValue { get; set; }
        public string AppUserActivityInputType { get; set; }
        public int AppUserActivityFrameSpeedDefined { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
