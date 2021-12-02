using Azure.Messaging.ServiceBus;
using MessageSender.Models;
using Newtonsoft.Json;

namespace MessageSender
{
    internal class MassTransitLogic
    {
        static ServiceBusClient _client;
        static ServiceBusSender _sender;

        /*
            Place documentation here
         */
        private async Task SendMessageQueue(object body, string connectionString, string queueName, string urnInfo)
        {
            _client = new ServiceBusClient(connectionString);

            _sender = _client.CreateSender(queueName);

            var request = JsonConvert.SerializeObject(body);
            
            await _sender.SendMessageAsync(request);
        }
    }
}