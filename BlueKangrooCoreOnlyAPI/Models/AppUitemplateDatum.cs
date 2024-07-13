using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUitemplateDatum
    {
        public Guid AppUitemplateDataId { get; set; }
        public string AppUitemplateData { get; set; }
        public string AppUitemplateMetaData { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
