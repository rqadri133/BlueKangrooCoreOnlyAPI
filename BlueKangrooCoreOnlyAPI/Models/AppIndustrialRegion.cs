using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppIndustrialRegion
    {
        public Guid AppIndustrialRegionD { get; set; }
        public string AppIndustrialRegionName { get; set; }
        public string AppIndustrialRegionState { get; set; }
        public string AppIndustrialRegionZipCode { get; set; }
        public int AppIndustrialRegionCountryCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
