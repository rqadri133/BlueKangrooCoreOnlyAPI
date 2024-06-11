using System.Text.Json;
using System.Text;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.Azure.ServiceBus;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System;
namespace BlueKangrooCoreOnlyAPI.Repositories {
    public class DispatchItemServiceBus<T> : IServiceBus<AppDispatchAssigned>
    {
        private readonly IConfiguration _configuration;

        public DispatchItemServiceBus(IConfiguration configuration)
        {
            this._configuration = configuration;


        }
        
          
        public async Task SendMessageAsync(AppDispatchAssigned dispatchAssigned) {
            IQueueClient client = new QueueClient(_configuration["AzureServiceBusConnectionString"], _configuration["QueueName"]);
            //Serialize car details object
            var messageBody = JsonSerializer.Serialize(dispatchAssigned);
            //Set content type and Guid
            var message = new Message(Encoding.UTF32.GetBytes(messageBody)) {
                MessageId = Guid.NewGuid().ToString(),
                    ContentType = "application/json"
            };
            await client.SendAsync(message);
        }
    }
}