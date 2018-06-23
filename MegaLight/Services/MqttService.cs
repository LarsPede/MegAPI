using MQTTnet;
using MQTTnet.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace MegaLight.Services
{
    public class MqttService
    {
        public MqttService()
        {

        }

        public async Task SendMessageAsync(string topic, string msg)
        {
            msg = Regex.Replace(msg, @"\s+", "");
            var factory = new MqttFactory();
            var mqttClient = factory.CreateMqttClient();
            // Use WebSocket connection.
            var options = new MqttClientOptionsBuilder()
                .WithClientId(Guid.NewGuid().ToString())
                .WithTcpServer(ConfigurationManager.AppSettings.Get("MqttServer"))
                .WithCredentials(ConfigurationManager.AppSettings.Get("MqttUser"), ConfigurationManager.AppSettings.Get("MqttPassword"))
                .WithTls()
                .Build();

            await mqttClient.ConnectAsync(options);

            var message = new MqttApplicationMessageBuilder()
                .WithTopic(topic)
                .WithPayload(msg)
                .WithAtMostOnceQoS()
                .WithRetainFlag()
                .Build();

            await mqttClient.PublishAsync(message);

            await mqttClient.DisconnectAsync();

            return;

        }

    }
}