using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUserRole
    {
        public Guid AppUserRoleId { get; set; }
        public string AppUserRoleName { get; set; }
        public string AppRoleNameDesc { get; set; }
        public string AppRoleAssociateDesc { get; set; }
        public bool CanView { get; set; }
        public bool CanEdit { get; set; }
        public bool CanCreate { get; set; }
        public bool CanDelete { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
