using Microsoft.Extensions.Logging;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Utilities
{
    public class BlueKangrooBlobStorage : IBlueKangrooStorage
    {
        public Task<FileInfo> DownloadFile(string containerPath,  IConfiguration config , ILogger logger)
        {
            throw new NotImplementedException();
        }

        public Task UploadFile(FileStream fileStream, string blobName, IConfiguration config, ILogger logger)
        {

            try
            {
                string _containerName = config["BlueKangrooContainerName"];
                //Copy the storage account connection string from Azure portal     
                string storageAccount_connectionString  = config["AzureBlobStorageConnection"] ;

              


                CloudStorageAccount mycloudStorageAccount = CloudStorageAccount.Parse(storageAccount_connectionString);
                CloudBlobClient blobClient = mycloudStorageAccount.CreateCloudBlobClient();
                CloudBlobContainer container = blobClient.GetContainerReference(_containerName);

                //checking the container exists or not  
                if (container.CreateIfNotExists())
                {

                    container.SetPermissionsAsync(new BlobContainerPermissions
                    {
                        PublicAccess =
                      BlobContainerPublicAccessType.Blob
                    });

                }

                //reading file name & file extention    
                string[] extension = blobName.Split(".".ToCharArray());
                CloudBlockBlob cloudBlockBlob = container.GetBlockBlobReference(blobName);
                cloudBlockBlob.Properties.ContentType = extension[1];
             
               return cloudBlockBlob.UploadFromStreamAsync(fileStream); // << Uploading the file to the blob >>  
            }
            catch(Exception excp )
            {
                logger.LogInformation("Unable to Upload file information" + excp.Message);
                throw excp;

            }
          
            
        }
    }
}
