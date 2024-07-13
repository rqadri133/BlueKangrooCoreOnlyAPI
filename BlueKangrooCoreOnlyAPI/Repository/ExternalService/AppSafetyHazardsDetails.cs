using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public class AppSafetyHazardsDetails
    {
         public Guid? SafetyHazardID {get;set;}
         public List<string> SafetyHazardNotes {get;set;}
         public DateTime CreatedDate {get;set;}
         

         public Guid? CreatedBy {get;set;}


    }
}