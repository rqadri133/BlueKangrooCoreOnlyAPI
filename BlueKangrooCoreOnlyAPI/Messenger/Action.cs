
using System;
using System.Collections.Generic;
using Azure.Messaging.ServiceBus;
using Microsoft.EntityFrameworkCore;

public class ComAction<T> where T: ServiceBusClient  
{
    public string ActionName 
    {
        get;
        set;
    }

    public Guid ActionID 
    {
        get;
        set;
    }

    public IActionDelegate<T> DelegateResponsibility 
    {
        get;
        set;
    }


    






}