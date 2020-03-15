using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppTray
    {
        public Guid AppTrayId { get; set; }
        public string AppTrayName { get; set; }
        public decimal AppTraySizeHeight { get; set; }
        public decimal AppTraySizeWidth { get; set; }
        public int AppTrayIsleNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
