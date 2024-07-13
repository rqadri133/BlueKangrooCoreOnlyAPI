using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using BlueKangrooCoreOnlyAPI.Models;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface ISenderRepository
    {
        public Task<AppSender> AddSenderInformation(AppSender sender);
        public Task<AppSender> UpdateSenderInformation(AppSender appSender );

        public Task<AppSender> DeleteSenderInformation(AppSender appSender);

        public Task<AppSender> GetSenderInformation(string phoneNumber);
        public Task<AppSender> GetSenderInformationById(Guid SenderId);


        public Task<List<AppSender>> GetAllSenders(string zipCode);

        public Task<AppDispatch> EveryThingAboutSender(Guid senderId);
        
    }

       
          


    }