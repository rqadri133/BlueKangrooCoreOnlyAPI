using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlueKangrooCoreOnlyAPI.Repository
{

    // Use on Dashoard Trade Center
    public interface IBKTradeCenterRepository
    {
         Task<List<AppBuyerSellerTrade>> GetAllTradeInformation();
         Task<List<AppBuyerSellerTrade>> FindAllTradeInformationForThisBuyer(AppBuyer buyer);
         Task<List<AppBuyerSellerTrade>> FindAllTradeInformationForThisSeller(AppSeller seller);
         
         // Return Encrytpted Transaction Document highly secure 
         Task<List<AppDocumentTransaction>> LoadAllTransactions(AppBuyer buyer, AppSeller seller);
         Task<List<AppSellerActivity>> GetAllSellerActivities(AppSeller seller);
         Task<List<AppBuyerActivity>> GetAllBuyerActivities(AppBuyer seller);

         // Extreme secure return  Highly secure encrypted financial institution...... 
         Task<List<AppFinancialInstituition>> LoadAllFinancialInstituitions(AppDocumentTransaction document);




    }
}
