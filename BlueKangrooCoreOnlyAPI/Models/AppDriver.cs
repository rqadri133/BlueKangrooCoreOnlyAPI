using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppDriver
    {
        public Guid AppDriverId { get; set; }
        public string AppDriverName { get; set; }
        public string AppDriverAddress { get; set; }
        public string AppDriverLicenseNumber { get; set; }
        public string AppDriverImageUrlphoto { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
