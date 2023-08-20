using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppDoorKey
    {
        public Guid AppDoorKeyId { get; set; }
        public string AppKeyName { get; set; }
        public string AppKeyCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
