using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUserSesion
    {
        public Guid AppSessionId { get; set; }
        public string AppSessionName { get; set; }
        public string AppClientUserIp { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
