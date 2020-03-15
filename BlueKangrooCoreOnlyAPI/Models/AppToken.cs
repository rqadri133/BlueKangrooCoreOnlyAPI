using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppToken
    {
        public Guid AppTokenId { get; set; }
        public string AppClientName { get; set; }
        public string AppNameDesc { get; set; }
        public Guid? AppTokenUserId { get; set; }
        public string AppUserPwd { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime TokenExpiredDate { get; set; }
    }
}
