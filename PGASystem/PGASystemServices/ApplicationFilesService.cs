﻿using System;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using PGASystemData;
using PGASystemData.Models;

namespace PGASystemServices
{
    public class ApplicationFilesService : IApplicationFiles
    {
        private readonly PGAContext _ctx; 
        public ApplicationFilesService(PGAContext ctx)
        {
            _ctx = ctx;
        }


        public CloudBlobContainer GetBlobContainer(string azureConnection, string containerName)
        {
            var storageAccount = CloudStorageAccount.Parse(azureConnection);
            var blobClient = storageAccount.CreateCloudBlobClient();

            /* Return a cloud blob container object */
            return blobClient.GetContainerReference(containerName);
        }

        public async Task SetFile(string title, Uri uri)
        {

            var file = new ApplicationFiles()
            {
                Title = title,
                Created = DateTime.Now,
                Url = uri.AbsoluteUri
            };

            _ctx.ApplicationFile.Add(file);
            await _ctx.SaveChangesAsync();
        }




    }
}