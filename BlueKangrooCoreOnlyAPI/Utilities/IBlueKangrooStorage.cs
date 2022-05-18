using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Utilities
{
    interface IBlueKangrooStorage
    {
        public Task UploadFile(FileStream fileStream, string blobName, IConfiguration config, ILogger logger);
        public Task<FileInfo> DownloadFile(string containerPath, IConfiguration config , ILogger logger );

    }
}
