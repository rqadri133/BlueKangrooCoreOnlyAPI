using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class ApplicationModel
    {
        public Guid AppId { get; set; }
        public string AppModelName { get; set; }
        public string AppServerIphashed { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
