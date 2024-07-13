using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppTokenDetail
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
