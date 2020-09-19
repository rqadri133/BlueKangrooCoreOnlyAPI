using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Utilities
{
    public class ProxyStorage
    {

        public static Task UploadToBlob(Guid productId, string blobName, FileStream fileInfo, IConfiguration config, ILogger logger)
        {
            IBlueKangrooStorage _storage = null;
            string storagemethod = config["StorageTechnique"];
            string _containerName = config["BlueKangrooContainerName"];
            switch (storagemethod)
            {

                case "AzureBlob":
                    _storage = new BlueKangrooBlobStorage();
                    break;
                default:
                    _storage = new BlueKangrooBlobStorage();
                    break;
            }

            return _storage.UploadFile(fileInfo, productId + "@" + blobName, config, logger);
        }
    }
}
