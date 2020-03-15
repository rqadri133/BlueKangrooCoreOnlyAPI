using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppTokenDetails
    {
        public Guid AppTokenDetailId { get; set; }
        public Guid AppTokenId { get; set; }
        public string AppCompanyId { get; set; }
        public string AppSecurePhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime TokenExpiredDate { get; set; }
    }
}
