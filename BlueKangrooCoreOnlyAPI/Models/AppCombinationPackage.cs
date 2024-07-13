using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppCombinationPackage
    {
        public Guid AppCombinationPackageId { get; set; }
        public string AppCombinationPackageDescription { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
