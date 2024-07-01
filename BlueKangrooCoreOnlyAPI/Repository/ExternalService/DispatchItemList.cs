using System;
using System.Collections.Generic;
using BlueKangrooCoreOnlyAPI.Models;

public class DispatchItemList
{
    public List<AppDispatchAssigned> AllItems {get;set;}
    public Applocation PickUpLocation {get;set;}
    public AppTruckRoute CurrentRoutes {get;set;}  



}