using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppPallete
    {
        public Guid AppPallateId { get; set; }
        public string AppPallateName { get; set; }
        public decimal AppPallateSizeHeight { get; set; }
        public decimal AppPallateSizeWidth { get; set; }
        public int AppAvailablePallets { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
