using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUserSessionCrossRefVar
    {
        public Guid AppSessionRefVarId { get; set; }
        public string AppSessionVarName { get; set; }
        public Guid AppSessionId { get; set; }
        public string AppSessionVarType { get; set; }
        public string AppSessionValueUpdate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
