using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUserActivityDetail
    {
        public Guid AppUserActivityDetailsId { get; set; }
        public Guid AppUserActivityId { get; set; }
        public string AppUserActivityInputId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
