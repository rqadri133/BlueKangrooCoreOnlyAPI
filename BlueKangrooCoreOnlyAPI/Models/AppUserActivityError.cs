using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUserActivityError
    {
        public Guid AppUserActivityErrorId { get; set; }
        public string AppUserActivityId { get; set; }
        public string AppUserActivityErrorDesc { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
