using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppUidataDependencyInjection
    {
        public Guid AppUidataInjectionId { get; set; }
        public Guid AppUitemplateId { get; set; }
        public string DataDependencyFileJson { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
