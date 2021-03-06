﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        /* Method adds a file to an Application. Note: URI is from Azure BLOB Storage */
        public async Task SetFile(string title, Uri uri)
        {

            var file = new ApplicationFiles()
            {
                Title = title,
                Created = DateTime.Now,
                Url = uri.AbsoluteUri,

                /* use last added application for reference */ 
                Application = _ctx.Applications.Last()


            };

            _ctx.ApplicationFile.Add(file);
            await _ctx.SaveChangesAsync();
        }
        /* Method gets all files pertaining to a specific application */
        public List<SelectListItem> GetFilesForApplication(int applicationId)
        {
           
            return  _ctx.ApplicationFile.Where(a => a.Application.Id == applicationId)
                        .Select(u => new SelectListItem()
                        {
                            Value = u.Url,
                            Text = u.Title
                        }).ToList();
        }

    }
}
