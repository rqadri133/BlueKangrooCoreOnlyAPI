using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppProperty
    {
        public Guid AppPropertyId { get; set; }
        public string AppPropertyName { get; set; }
        public Guid AppDataTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
