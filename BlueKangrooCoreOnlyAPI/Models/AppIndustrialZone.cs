using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppIndustrialZone
    {
        public Guid AppIndustrialZoneId { get; set; }
        public string AppIndustrialZoneName { get; set; }
        public Guid AppIndustrialRegionId { get; set; }
        public string AppZonePopulation { get; set; }
        public int AppZoneEmployeePopulation { get; set; }
        public int? AppZoneEmployerPopulation { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
