using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public class AppLoader
    {
       public Guid? LoaderID {get;set;}
       public AppCompany LoaderCompanyDetails {get;set;} 
       public AppEquipment LoadEquipmentDetails {get;set;}
       public AppSafetyHazardsDetails SafetyHazardsDetails {get;set;}
      

    }
}