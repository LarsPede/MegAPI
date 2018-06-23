using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace MegaLight.Services
{
    public class InformationBroker
    {
        public const int BatteryLow = 1;
        public const int MorningBattery = 2;
        public const int EveningBattery = 3;
        static HttpClient client = new HttpClient();

        public void SendSms(int typeOfSms, float batteryVoltage = (float) 11.5)
        {
            List<int> numbers = new List<int>();
            var configNumbers = ConfigurationManager.AppSettings.Get("smsRecievers").Split(',').ToList<string>();
            foreach (string configNumber in configNumbers)
            {
                numbers.Add(Int32.Parse(configNumber));
            }
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://api.suresms.com/Script/sendSMS.aspx");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            string query = "?login=" + ConfigurationManager.AppSettings.Get("smsUser") + "&password=" + ConfigurationManager.AppSettings.Get("smsPassword");
            switch (typeOfSms)
            {
                case 1:
                    query += "&text=";
                    query += "Battery LOW! Change NOW!------ This has been a status message from the MegaBoominator.-----";
                    break;
                case 2:
                    query += "&text=";
                    query += "Goodmorning. The battery is currently at: " + batteryVoltage + "V------ This has been a status message from the MegaBoominator.-----";
                    break;
                case 3:
                    query += "&text=";
                    query += "Goodevening. The battery is currently at: " + batteryVoltage + "V------ This has been a status message from the MegaBoominator.-----";
                    break;
                default:
                    query += "&text=";
                    query += "Battery LOW! Change NOW!------ This has been a status message from the MegaBoominator.-----";
                    break;
            }
            foreach (int number in numbers)
            {
                string finalQuery = query + "&to=" + ConfigurationManager.AppSettings.Get("smsCountry") + number;
                client.GetAsync(finalQuery);
            }
        }
    }
}