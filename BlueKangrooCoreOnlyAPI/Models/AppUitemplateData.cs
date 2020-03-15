using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUitemplateData
    {
        public Guid AppUitemplateDataId { get; set; }
        public string AppUitemplateData1 { get; set; }
        public string AppUitemplateMetaData { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
