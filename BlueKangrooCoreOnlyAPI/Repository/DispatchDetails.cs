using BlueKangrooCoreOnlyAPI.Models;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    using System;
    using System.Collections.Generic;
    public class DispatchDetails
    {
        public Guid? DispatchID {get;set;}
        public string DispatchNotes {get;set;}
        public List<DispatchItemList> ItemsToDsipatch { get;set;}

    }

    
}