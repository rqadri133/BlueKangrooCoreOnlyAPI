using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppKey
    {
        public Guid AppKeyId { get; set; }
        public string AppKeyDesc { get; set; }
        public string AppClientEmailId { get; set; }
        public string AppClientIpadressAllowed { get; set; }
        public string AppClientPhone { get; set; }
        public string AppClientCompany { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
