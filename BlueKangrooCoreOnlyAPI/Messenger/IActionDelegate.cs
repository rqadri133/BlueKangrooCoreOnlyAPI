
using System.Collections.Generic;
using Azure.Messaging.ServiceBus;
using System.Text;
public interface IActionDelegate<T>  where T: ServiceBusClient
{
     public bool SendToServiceBus(T actionClass,string busName);
     public bool SendToServiceBus(StringBuilder builder, string busName);
     public bool SendStopProcessingCode(T actionClass,string code);
     public bool DisburseTransactions(T actionClass) ;



}