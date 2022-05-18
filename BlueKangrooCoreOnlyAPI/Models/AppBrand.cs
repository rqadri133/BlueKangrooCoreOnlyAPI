using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppBrand
    {
        public Guid AppBrandId { get; set; }
        public string AppBrandName { get; set; }
        public string AppBrandLicenseId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
