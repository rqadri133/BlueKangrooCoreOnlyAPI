using System;
using System.Collections.Generic;


interface DispatcherService<T>  where T : DispatchItemList
{
      int SendItemsToQueue(T items , int queueID);
      DispatchItemList ProcessedItemsList(int queueID);


}