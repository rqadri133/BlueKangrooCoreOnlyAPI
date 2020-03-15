using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppPackageHandler
    {
        public Guid AppPackageHandlerId { get; set; }
        public string AppPakageHandlerName { get; set; }
        public string AppPackageHandlerStateId { get; set; }
        public string AppPackageHandlerFitnessNotes { get; set; }
        public Guid LastHandledFreightIdref { get; set; }
        public DateTime LastPackageHandledDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
