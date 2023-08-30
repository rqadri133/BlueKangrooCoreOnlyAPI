using System;
using System.Collections.Generic;
using System.Linq;
using BlueKangrooCoreOnlyAPI.Models;
using RulesEngine.Actions;
using RulesEngine;
using RulesEngine.Models;
using Microsoft.Extensions.Configuration;

public enum PackageHandlerStatus 
{
    InProgress,
    Success,
    Failed
}

namespace BlueKangrooCoreOnlyAPI.Handlers {

  public interface IPackageLogisticsGenerationRule {
        public PackageHandlerStatus ProcessPackage(Workflow rules , IConfiguration configuration);
        
      
  }




}