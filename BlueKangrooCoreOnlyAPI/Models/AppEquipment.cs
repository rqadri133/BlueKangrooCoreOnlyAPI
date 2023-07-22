using System;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public class AppEquipment
    {
        public Guid? EquipmentID { get;set;}
        public string EquipmentName {get;set;}
        public DateTime CreatedDate {get;set;}

        public bool IsActiveReadyToUse {get;set;}

        public Guid? CreatedBy {get;set;}
    }
}