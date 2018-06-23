using MegaLight.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Linq;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System;
using MegaLight.DAL;
using MegaLight.Services;
using System.Configuration;
using System.Globalization;

namespace MegaLight.Controllers
{
    public class LightController : ApiController
    {
        public LightController()
        {
        }

        /// <summary>
        /// get current light status
        /// </summary>
        /// <returns>Light / error</returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK,
            Type = typeof(GetLight))]
        [Route("~/getLit")]
        public JObject GetLights()
        {
            try
            {
                var context = new DatabaseContext();
                var count = context.Lights.Count();
                Light light = context.Lights.OrderByDescending(x => x.Id).FirstOrDefault();
                GetLight response;
                if (light == null)
                {
                    response = new GetLight { Animation = null, Brightness = 0, Color = new Color { R = 0, G = 0, B = 0 } };
                } else
                {
                    response = new GetLight { Animation = light.Animation, Brightness = light.Brightness, Color = light.Color };
                }
                return JObject.FromObject(response);
            }
            catch (Exception e)
            {
                var value = "{ \"response\": \"error " + e.Message + "\" }";
                return JObject.Parse(value);

            }
        }

        /// <summary>
        /// Get last seven days for everything
        /// </summary>
        /// <returns>success/fail</returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK,
            Type = typeof(JObject))]
        [Route("~/getStatus")]
        public JObject GetStatus()
        {
            try
            {
                Status completeStatus;
                var context = new DatabaseContext();
                var dataWeekStart = DataCruncher.DataWeekStart();
                var amounts = context.Amounts.Where(x => x.DateTime > dataWeekStart).ToList();
                var dataWeek = DataCruncher.CrunchLastWeekData(amounts);
                var batteryWeekStart = DataCruncher.BatteryWeekStart();
                var batteries = context.Batteries.Where(x => x.DateTime > batteryWeekStart).ToList();
                var batteryWeek = DataCruncher.CrunchLastWeekBatteryData(batteries);
                Average lastUpdatedAverage = context.Averages.OrderByDescending(x => x.DateTime).FirstOrDefault();
                if (lastUpdatedAverage == null)
                {
                    completeStatus = new Status { Avg = new UpDown { Up = 0, Down = 0 }, BatteryWeek = batteryWeek, DataWeek = dataWeek };
                } else
                {
                    completeStatus = new Status { Avg = new UpDown { Up = lastUpdatedAverage.Up, Down = lastUpdatedAverage.Down }, BatteryWeek = batteryWeek, DataWeek = dataWeek };
                }
                return JObject.FromObject(completeStatus);
            }
            catch (Exception e)
            {
                var value = "{ \"response\": \"error " + e.Message + "\" }";
                return JObject.Parse(value);

            }
        }

        /// <summary>
        /// Get latest average
        /// </summary>
        /// <returns>success/fail</returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK,
            Type = typeof(JObject))]
        [Route("~/getAverage")]
        public JObject GetAverage()
        {
            try
            {
                var context = new DatabaseContext();
                var lastUpdatedAverage = context.Averages.OrderByDescending(x => x.DateTime).FirstOrDefault();
                if (lastUpdatedAverage == null)
                {
                    lastUpdatedAverage = new Average
                    {
                        Up = 0,
                        Down = 0
                    };
                }
                var response = new UpDown
                {
                    Up = lastUpdatedAverage.Up,
                    Down = lastUpdatedAverage.Down
                };

                return JObject.FromObject(response);
            }
            catch (Exception e)
            {
                var value = "{ \"response\": \"error " + e.Message + "\" }";
                return JObject.Parse(value);

            }
        }

        /// <summary>
        /// Get Dataweek
        /// </summary>
        /// <returns>success/fail</returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK,
            Type = typeof(JObject))]
        [Route("~/getBatteries")]
        public List<JObject> GetVoltage()
        {
            try
            {
                var context = new DatabaseContext();
                var currentBatteryId = context.Settings.Find(Int32.Parse(ConfigurationManager.AppSettings.Get("Battery"))).Value;
                List<string> distinctBatteries = context.Batteries.DistinctBy(x => x.BatteryId).Select(x => x.BatteryId).ToList();
                List<GetBattery> batteries = new List<GetBattery>();

                foreach (string distinctBattery in distinctBatteries)
                {
                    batteries.Add(context.Batteries
                    .Where(x => x.BatteryId == distinctBattery)
                    .OrderByDescending(x => x.Id)
                    .Take(1)
                    .Select(x =>
                        distinctBattery == currentBatteryId ?
                            new GetBattery
                            {
                                BatteryId = x.BatteryId,
                                Voltage = x.Voltage,
                                CurrentBattery = true
                            } :
                            new GetBattery
                            {
                                BatteryId = x.BatteryId,
                                Voltage = x.Voltage,
                                CurrentBattery = false
                            })
                    .FirstOrDefault());
                }
                List<JObject> response = batteries.Select(x => JObject.FromObject(x)).ToList();
                return response;
            }
            catch (Exception e)
            {
                var value = "{ \"response\": \"error " + e.Message + "\" }";
                List<JObject> response = new List<JObject>
                {
                    JObject.Parse(value)
                };
                return response;

            }
        }

        /// <summary>
        /// Get Batteryweek
        /// </summary>
        /// <returns>success/fail</returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK,
            Type = typeof(JObject))]
        [Route("~/getBatteryHistoric")]
        public JObject GetBatteryWeek()
        {
            try
            {
                var context = new DatabaseContext();
                var batteryWeekStart = DataCruncher.BatteryWeekStart();
                var batteries = context.Batteries.Where(x => x.DateTime > batteryWeekStart).ToList();
                var batteryWeek = DataCruncher.CrunchLastWeekBatteryData(batteries);
                return JObject.FromObject(batteryWeek);
            }
            catch (Exception e)
            {
                var value = "{ \"response\": \"error " + e.Message + "\" }";
                return JObject.Parse(value);

            }
        }

        /// <summary>
        /// Get Batteryweek
        /// </summary>
        /// <returns>success/fail</returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK,
            Type = typeof(JObject))]
        [Route("~/getDataHistoric")]
        public JObject GetDataWeek()
        {
            try
            {
                var context = new DatabaseContext();
                var dataWeekStart = DataCruncher.DataWeekStart();
                var amounts = context.Amounts.Where(x => x.DateTime > dataWeekStart).ToList();
                var dataWeek = DataCruncher.CrunchLastWeekData(amounts);
                return JObject.FromObject(dataWeek);
            }
            catch (Exception e)
            {
                var value = "{ \"response\": \"error " + e.Message + "\" }";
                return JObject.Parse(value);

            }
        }

        /// <summary>
        /// Gets pong
        /// </summary>
        /// <returns>The contacts</returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK,
            Type = typeof(JObject))]
        [Route("~/ping")]
        public JObject Ping()
        {
            var value = "{ \"response\": \"pong\" }";
            return JObject.Parse(value);
        }

        /// <summary>
        /// Gets pong
        /// </summary>
        /// <returns>The contacts</returns>
        [Authorize]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK,
            Type = typeof(JObject))]
        [Route("~/restart")]
        public JObject PiRestart()
        {
            try
            {
                var context = new DatabaseContext();
                var setting = context.Settings.Find(Int32.Parse(ConfigurationManager.AppSettings.Get("NewCycle")));
                setting.Value = "Mega";
                context.SaveChanges();

                var value = "{ \"response\": \"success\" }";
                return JObject.Parse(value);
            }
            catch (Exception e)
            {
                var value = "{ \"response\": \"error " + e.Message + "\" }";
                return JObject.Parse(value);

            }
        }

        /// <summary>
        /// Sends a sms with status
        /// </summary>
        /// <returns>The contacts</returns>
        [Authorize]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK,
            Type = typeof(JObject))]
        [Route("~/dailyStatus")]
        public JObject DailyStatus()
        {
            var context = new DatabaseContext();
            var latestBattery = context.Batteries.OrderByDescending(x => x.Id).FirstOrDefault();
            var ib = new InformationBroker();
            if(DateTime.Now.Hour < 12)
            {
                ib.SendSms(InformationBroker.MorningBattery, latestBattery.Voltage);
            } else
            {
                ib.SendSms(InformationBroker.EveningBattery, latestBattery.Voltage);
            }
            var value = "{ \"response\": \"messageSend\" }";
            return JObject.Parse(value);
        }

        /// <summary>
        /// Sends led information or saves it
        /// </summary>
        /// <returns>The saved contact</returns>
        [Authorize]
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK,
            Description = "set lights",
            Type = typeof(JObject))]
        [Route("~/setLights")]
        public async Task<JObject> SetLightsAsync([FromBody] Light light)
        {
            try
            {
                if (light.Controller)
                {
                    var context = new DatabaseContext();
                    context.Lights.Add(light);
                    context.SaveChanges();
                }
                else
                {
                    var service = new MqttService();
                    GetLight newLight = new GetLight() { Animation = light.Animation, Brightness = light.Brightness, Color = light.Color };
                    await service.SendMessageAsync("boominator", JObject.FromObject(newLight).ToString());
                }
                var value = "{ \"response\": \"success\" }";
                return JObject.Parse(value);
            }
            catch (Exception e)
            {
                var value = "{ \"response\": \"error " + e.Message + "\" }";
                return JObject.Parse(value);

            }
        }

        /// <summary>
        /// Saves avg and amount information
        /// </summary>
        /// <returns>success/fails</returns>
        [Authorize]
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK,
            Description = "Set new status",
            Type = typeof(JObject))]
        [Route("~/setStatus")]
        public JObject SetStatus([FromBody] ConsumptionInformation consumption)
        {
            try
            {
                var context = new DatabaseContext();
                context.Averages.Add(consumption.AvgSpeed);
                var newCycle = context.Settings.Find(Int32.Parse(ConfigurationManager.AppSettings.Get("NewCycle")));
                var minusUp = context.Settings.Find(Int32.Parse(ConfigurationManager.AppSettings.Get("MinusUpNumber")));
                var minusDown = context.Settings.Find(Int32.Parse(ConfigurationManager.AppSettings.Get("MinusDownNumber")));
                if (newCycle.Value != null)
                {
                    newCycle.Value = null;
                    minusUp.Value = "0";
                    minusDown.Value = "0";
                }
                else
                {
                    float minusUpNumber = float.Parse(minusUp.Value, CultureInfo.InvariantCulture);
                    float minusDownNumber = float.Parse(minusDown.Value, CultureInfo.InvariantCulture);
                    consumption.DataAmount.Up -= minusUpNumber;
                    consumption.DataAmount.Down -= minusDownNumber;
                    minusUpNumber += consumption.DataAmount.Up;
                    minusDownNumber += consumption.DataAmount.Down;
                    minusUp.Value = minusUpNumber.ToString();
                    minusDown.Value = minusDownNumber.ToString();
                }
                context.Amounts.Add(consumption.DataAmount);
                context.SaveChanges();
                var value = "{ \"response\": \"success\" }";
                return JObject.Parse(value);
            }
            catch (Exception e)
            {
                var value = "{ \"response\": \"error " + e.Message + "\" }";
                return JObject.Parse(value);

            }
        }

        /// <summary>
        /// Saves Battery information
        /// </summary>
        /// <returns>The saved contact</returns>
        [Authorize]
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK,
            Description = "Set new Voltage information",
            Type = typeof(JObject))]
        [Route("~/setVoltage")]
        public JObject SetVoltage([FromBody] BatteryInformation battery)
        {
            try
            {
                var context = new DatabaseContext();
                context.Batteries.Add(new Battery() { BatteryId = context.Settings.Find(Int32.Parse(ConfigurationManager.AppSettings.Get("Battery"))).Value, Voltage = (float)battery.Voltage, DateTime = DateTime.Now });
                context.SaveChanges();

                var informationSend = context.Settings.Find(Int32.Parse(ConfigurationManager.AppSettings.Get("BatteryInformationSend")));
                if (informationSend.Value != null && battery.Voltage > 12)
                {
                    informationSend.Value = null;
                    context.SaveChanges();
                }
                if (informationSend.Value == null && battery.Voltage < 11.5)
                {
                    var ib = new InformationBroker();
                    ib.SendSms(InformationBroker.BatteryLow);
                    informationSend.Value = "Mega";
                    context.SaveChanges();
                }
                var value = "{ \"response\": \"success\" }";
                return JObject.Parse(value);
            }
            catch (Exception e)
            {
                var value = "{ \"response\": \"error " + e.Message + "\" }";
                return JObject.Parse(value);

            }
        }

        /// <summary>
        /// Saves Battery information
        /// </summary>
        /// <returns>The saved contact</returns>
        [Authorize]
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK,
            Description = "Set new Battery",
            Type = typeof(JObject))]
        [Route("~/changeBattery")]
        public JObject ChangeBattery([FromBody] ChangeBattery cb)
        {
            try
            {
                var context = new DatabaseContext();
                var setting = context.Settings.Find(Int32.Parse(ConfigurationManager.AppSettings.Get("Battery")));
                setting.Value = cb.BatId;
                context.SaveChanges();
                
                var value = "{ \"response\": \"success\" }";
                return JObject.Parse(value);
            }
            catch (Exception e)
            {
                var value = "{ \"response\": \"error " + e.Message + "\" }";
                return JObject.Parse(value);

            }
        }
    }
}