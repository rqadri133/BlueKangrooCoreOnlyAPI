using System;
using System.Collections.Generic;
namespace BlueKangrooCoreOnlyAPI.Models
{
    public class AppDispatch 
    {
        public Guid? DispatchItemID {get;set;}
        public DispatchItemList ItemList {get;set;}
        public DateTime CreatedDate {get;set;}
        public Guid? CreatedBy {get;set;}



    }
}