using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppFreightType
    {
        public Guid AppFreightTypeId { get; set; }
        public string AppFreightTypeName { get; set; }
        public string AppFreightTypeDesc { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
