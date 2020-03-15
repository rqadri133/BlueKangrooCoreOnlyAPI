using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppSensitiveMaterial
    {
        public Guid AppSensitiveMateriaId { get; set; }
        public string AppSensativeMaterialName { get; set; }
        public string AppSensativeMaterialNotesEncrypted { get; set; }
        public string AppBuyerHashedSsc { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
