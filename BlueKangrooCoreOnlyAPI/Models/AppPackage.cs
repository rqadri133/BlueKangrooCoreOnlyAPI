using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppPackage
    {
        public Guid AppPackageId { get; set; }
        public string AppPakagerName { get; set; }
        public decimal AppPackageWidth { get; set; }
        public decimal AppPackaheHeight { get; set; }
        public decimal AppPackageDepth { get; set; }
        public bool IsSensativeMaterialInside { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
