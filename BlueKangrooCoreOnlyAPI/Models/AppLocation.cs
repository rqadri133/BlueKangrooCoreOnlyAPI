using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{

 public class AppLocation
 {
    public Guid? LocationID {get;set;}
    public String City {get;set;}
    public string State {get;set;}
    public string StreetAddress {get;set;}
    public string SuitNameNumber {get;set;}
    public string ParkingLotNumberDesc {get;set;}
    public string PickUpReserveSpotParking {get;set;}

    public AppLoader LoaderDetails {get;set;}  
    

 }

}