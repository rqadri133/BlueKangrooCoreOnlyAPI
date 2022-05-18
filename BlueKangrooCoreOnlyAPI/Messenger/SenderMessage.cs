using System;
using System.Collections.Generic;
using Azure.Messaging.ServiceBus;


public class SenderMessage<T> where T: ServiceBusClient
{
    public string Message
    {
        get;
        set;
    }
    public Guid MessageID 
    {
        get;
        set;
    }

    public ComAction<T> ActionContext 
    {
        get;
        set;
    }

    public TimeSpan ActionTriggerIntervalWait
    {
        get;
        set;
    }

    public TimeSpan MessageProcessingTime
    {
        get;
        set;


    }


    public DateTime MessageSentOutTime
    {
        get;
        set;
    }

    




}