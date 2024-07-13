using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppTokenGeneration
    {
        public Guid AppTokenId { get; set; }
        public string AppTokenGenId { get; set; }
        public string AppTokenGenOid { get; set; }
        public Guid AppUserId { get; set; }
        public string ClientNameDesc { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
