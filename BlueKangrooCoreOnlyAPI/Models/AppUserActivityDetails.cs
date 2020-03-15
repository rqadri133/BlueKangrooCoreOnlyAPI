using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUserActivityDetails
    {
        public Guid AppUserActivityDetailsId { get; set; }
        public Guid AppUserActivityId { get; set; }
        public string AppUserActivityInputId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
