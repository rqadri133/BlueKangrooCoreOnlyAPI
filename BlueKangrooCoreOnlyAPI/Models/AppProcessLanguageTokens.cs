using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppProcessLanguageTokens
    {
        public Guid LanguageTokenId { get; set; }
        public string LanguageTokenSymbol { get; set; }
        public string ReadFunctionalityOfTokenJson { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
