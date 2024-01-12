using System;
using System.Collections.Generic;
using System.Text.Json;
using BlueKangrooCoreOnlyAPI.Models;
using Newtonsoft.Json;


public class JsonUtilityManager<T> where T : List<PackageDetails> 
{


     
     public static string ProcessDataModeToJson(List<PackageDetails> packagDetails )
     {
             string jsonDocument = String.Empty;
             if(packagDetails != null && packagDetails.Count > 0)
             {
                jsonDocument = JsonConvert.SerializeObject(packagDetails);
             }
             return jsonDocument;

     }




}