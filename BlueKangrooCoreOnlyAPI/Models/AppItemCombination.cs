using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppItemCombination
    {
        public Guid AppItemCombinationId { get; set; }
        public int AppItemCombinationPackageId { get; set; }
        public Guid AppProductId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
