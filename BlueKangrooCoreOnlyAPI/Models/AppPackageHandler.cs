using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppPackageHandler
    {
        public Guid PackageId { get; set; }
        public string PackageName { get; set; }
        public string PackageDescription { get; set; }
        public string PackageTrackerUpdateInfo { get; set; }
        public string BoxWidth { get; set; }
        public string BoxHeight { get; set; }
        public string DepthZindex { get; set; }
        public decimal MaxPoundsOccupancy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
