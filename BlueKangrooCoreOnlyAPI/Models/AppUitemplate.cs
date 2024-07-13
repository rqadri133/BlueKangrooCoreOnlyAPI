using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUitemplate
    {
        public Guid AppUitemplateId { get; set; }
        public string AppUitemplateName { get; set; }
        public string AppUitemplateDesc { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
