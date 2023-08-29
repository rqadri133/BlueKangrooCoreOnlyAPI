using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueKangrooCoreOnlyAPI.Proxies 
{
    public class PackageHanlder
    {
        public Guid PackageHandlerID { get; set; }
        public string PackageTrackerID { get; set;}
        public string PackageDescription { get; set;}
        public int BOXWidth {get;set;}

        public int BoxHeight {get;set;}

        public int depthZIndex {get;set;}

        public double MaxPoundsOccupancy {get;set;} 

    }

}


