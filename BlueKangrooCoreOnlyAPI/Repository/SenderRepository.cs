    using BlueKangrooCoreOnlyAPI.Models;
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Data;
using Microsoft.EntityFrameworkCore;
using Amazon.Runtime.Internal.Util;

namespace BlueKangrooCoreOnlyAPI.Repository
    {
        /// <summary>
        /// This code needs the sender to be in Queue Pipeline
        /// Add Azure Service Bus Subscription and add List of Senders
        /// </summary>
        public class SenderRepository : ISenderRepository
        {
            private readonly blueKangrooContext db;
            
            public SenderRepository(blueKangrooContext _db) 
            {
                db = _db;

            }

        public Task<AppSender> AddSenderInformation(AppSender sender)
        {
            throw new NotImplementedException();
        }

        public Task<AppSender> DeleteSenderInformation(AppSender appSender)
        {
            throw new NotImplementedException();
        }

        public Task<AppDispatch> EveryThingAboutSender(Guid senderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AppSender>> GetAllSenders(string zipCode)
        {
            throw new NotImplementedException();
        }

        public Task<AppSender> GetSenderInformation(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<AppSender> GetSenderInformationById(Guid SenderId)
        {
            throw new NotImplementedException();
        }

        public Task<AppSender> UpdateSenderInformation(AppSender appSender)
        {
            throw new NotImplementedException();
        }
     }
    }