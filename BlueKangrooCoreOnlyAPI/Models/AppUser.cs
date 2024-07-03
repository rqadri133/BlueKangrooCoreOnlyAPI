using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{

    public   class AppUserModelDTO
    {

        public string AppUserId { get; set; }
        public string AppUserName { get; set; }
        public string AppNameDesc { get; set; }
        public string AppRoleId { get; set; }
        public string AppUserPwd { get; set; }
        public string CreatedBy { get; set; }  
    }
    public partial  class AppUser
    {
        public Guid AppUserId { get; set; }
        public string AppUserName { get; set; }
        public string AppNameDesc { get; set; }
        public Guid? AppRoleId { get; set; }
        public string AppUserPwd { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
