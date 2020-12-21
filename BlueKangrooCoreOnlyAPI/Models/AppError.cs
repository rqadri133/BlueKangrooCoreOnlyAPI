using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppError
    {
        public int AppErrorCode { get; set; }
        public string AppErrorDescription { get; set; }
        public string ErrorType { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
