using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppError
    {
        public int AppErrorCodeId { get; set; }
        public string AppErrorType { get; set; }
        public string AppErrorDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
