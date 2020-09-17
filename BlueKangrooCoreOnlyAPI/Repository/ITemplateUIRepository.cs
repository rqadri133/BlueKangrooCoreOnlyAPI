using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface ITemplateUIRepository
    {
        Task<AppUitemplate> AddTemplateUIInfo(AppUitemplate templateInfo);
        Task<List<AppUitemplate>> LoadAllUITemplates();
        Task<int> DeleteTemplateUIInfo(Guid? templateUid);
        Task<AppUitemplate> GetTemplateInfo(Guid? templateInfo);
        Task<AppUitemplate> UpdateTemplateInfo(AppUitemplate templateInfo);
    }
}
