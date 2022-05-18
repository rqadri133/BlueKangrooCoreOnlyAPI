using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUserRoleDetail
    {
        public Guid AppUserRoleDetailId { get; set; }
        public string AppUserRoleDetailDesc { get; set; }
        public Guid AppUserRoleId { get; set; }
        public Guid AppUitemplateId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
