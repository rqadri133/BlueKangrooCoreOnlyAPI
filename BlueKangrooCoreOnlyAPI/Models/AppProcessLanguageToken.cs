using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppProcessLanguageToken
    {
        public Guid LanguageTokenId { get; set; }
        public string LanguageTokenSymbol { get; set; }
        public string ReadFunctionalityOfTokenJson { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
