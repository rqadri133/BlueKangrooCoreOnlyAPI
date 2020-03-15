using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppGroundPlacementParkNumber
    {
        public Guid PlacementNumberId { get; set; }
        public string PlacementNumberTag { get; set; }
        public Guid PlacementParkId { get; set; }
        public decimal PlacementNumberHeight { get; set; }
        public decimal PlacementParkSquareWidth { get; set; }
        public string PlacementParkStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
