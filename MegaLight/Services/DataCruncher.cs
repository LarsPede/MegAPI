using MegaLight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaLight.Services
{
    public class DataCruncher
    {
        public static DataWeek CrunchLastWeekData(List<Amount> weekOldData)
        {
            var dataWeek = new DataWeek();
            foreach (Amount data in weekOldData)
            {
                switch (data.DateTime.Hour)
                {
                    case 0:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[0].Up += data.Up;
                            dataWeek.Monday[0].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[0].Up += data.Up;
                            dataWeek.Tuesday[0].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[0].Up += data.Up;
                            dataWeek.Wednesday[0].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[0].Up += data.Up;
                            dataWeek.Thursday[0].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[0].Up += data.Up;
                            dataWeek.Friday[0].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[0].Up += data.Up;
                            dataWeek.Saturday[0].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[0].Up += data.Up;
                            dataWeek.Sunday[0].Down += data.Down;
                        }
                        break;
                    case 1:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[1].Up += data.Up;
                            dataWeek.Monday[1].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[1].Up += data.Up;
                            dataWeek.Tuesday[1].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[1].Up += data.Up;
                            dataWeek.Wednesday[1].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[1].Up += data.Up;
                            dataWeek.Thursday[1].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[1].Up += data.Up;
                            dataWeek.Friday[1].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[1].Up += data.Up;
                            dataWeek.Saturday[1].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[1].Up += data.Up;
                            dataWeek.Sunday[1].Down += data.Down;
                        }
                        break;
                    case 2:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[2].Up += data.Up;
                            dataWeek.Monday[2].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[2].Up += data.Up;
                            dataWeek.Tuesday[2].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[2].Up += data.Up;
                            dataWeek.Wednesday[2].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[2].Up += data.Up;
                            dataWeek.Thursday[2].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[2].Up += data.Up;
                            dataWeek.Friday[2].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[2].Up += data.Up;
                            dataWeek.Saturday[2].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[2].Up += data.Up;
                            dataWeek.Sunday[2].Down += data.Down;
                        }
                        break;
                    case 3:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[3].Up += data.Up;
                            dataWeek.Monday[3].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[3].Up += data.Up;
                            dataWeek.Tuesday[3].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[3].Up += data.Up;
                            dataWeek.Wednesday[3].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[3].Up += data.Up;
                            dataWeek.Thursday[3].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[3].Up += data.Up;
                            dataWeek.Friday[3].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[3].Up += data.Up;
                            dataWeek.Saturday[3].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[3].Up += data.Up;
                            dataWeek.Sunday[3].Down += data.Down;
                        }
                        break;
                    case 4:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[4].Up += data.Up;
                            dataWeek.Monday[4].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[4].Up += data.Up;
                            dataWeek.Tuesday[4].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[4].Up += data.Up;
                            dataWeek.Wednesday[4].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[4].Up += data.Up;
                            dataWeek.Thursday[4].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[4].Up += data.Up;
                            dataWeek.Friday[4].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[4].Up += data.Up;
                            dataWeek.Saturday[4].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[4].Up += data.Up;
                            dataWeek.Sunday[4].Down += data.Down;
                        }
                        break;
                    case 5:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[5].Up += data.Up;
                            dataWeek.Monday[5].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[5].Up += data.Up;
                            dataWeek.Tuesday[5].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[5].Up += data.Up;
                            dataWeek.Wednesday[5].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[5].Up += data.Up;
                            dataWeek.Thursday[5].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[5].Up += data.Up;
                            dataWeek.Friday[5].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[5].Up += data.Up;
                            dataWeek.Saturday[5].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[5].Up += data.Up;
                            dataWeek.Sunday[5].Down += data.Down;
                        }
                        break;
                    case 6:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[6].Up += data.Up;
                            dataWeek.Monday[6].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[6].Up += data.Up;
                            dataWeek.Tuesday[6].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[6].Up += data.Up;
                            dataWeek.Wednesday[6].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[6].Up += data.Up;
                            dataWeek.Thursday[6].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[6].Up += data.Up;
                            dataWeek.Friday[6].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[6].Up += data.Up;
                            dataWeek.Saturday[6].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[6].Up += data.Up;
                            dataWeek.Sunday[6].Down += data.Down;
                        }
                        break;
                    case 7:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[7].Up += data.Up;
                            dataWeek.Monday[7].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[7].Up += data.Up;
                            dataWeek.Tuesday[7].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[7].Up += data.Up;
                            dataWeek.Wednesday[7].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[7].Up += data.Up;
                            dataWeek.Thursday[7].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[7].Up += data.Up;
                            dataWeek.Friday[7].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[7].Up += data.Up;
                            dataWeek.Saturday[7].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[7].Up += data.Up;
                            dataWeek.Sunday[7].Down += data.Down;
                        }
                        break;
                    case 8:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[8].Up += data.Up;
                            dataWeek.Monday[8].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[8].Up += data.Up;
                            dataWeek.Tuesday[8].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[8].Up += data.Up;
                            dataWeek.Wednesday[8].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[8].Up += data.Up;
                            dataWeek.Thursday[8].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[8].Up += data.Up;
                            dataWeek.Friday[8].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[8].Up += data.Up;
                            dataWeek.Saturday[8].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[8].Up += data.Up;
                            dataWeek.Sunday[8].Down += data.Down;
                        }
                        break;
                    case 9:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[9].Up += data.Up;
                            dataWeek.Monday[9].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[9].Up += data.Up;
                            dataWeek.Tuesday[9].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[9].Up += data.Up;
                            dataWeek.Wednesday[9].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[9].Up += data.Up;
                            dataWeek.Thursday[9].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[9].Up += data.Up;
                            dataWeek.Friday[9].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[9].Up += data.Up;
                            dataWeek.Saturday[9].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[9].Up += data.Up;
                            dataWeek.Sunday[9].Down += data.Down;
                        }
                        break;
                    case 10:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[10].Up += data.Up;
                            dataWeek.Monday[10].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[10].Up += data.Up;
                            dataWeek.Tuesday[10].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[10].Up += data.Up;
                            dataWeek.Wednesday[10].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[10].Up += data.Up;
                            dataWeek.Thursday[10].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[10].Up += data.Up;
                            dataWeek.Friday[10].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[10].Up += data.Up;
                            dataWeek.Saturday[10].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[10].Up += data.Up;
                            dataWeek.Sunday[10].Down += data.Down;
                        }
                        break;
                    case 11:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[11].Up += data.Up;
                            dataWeek.Monday[11].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[11].Up += data.Up;
                            dataWeek.Tuesday[11].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[11].Up += data.Up;
                            dataWeek.Wednesday[11].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[11].Up += data.Up;
                            dataWeek.Thursday[11].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[11].Up += data.Up;
                            dataWeek.Friday[11].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[11].Up += data.Up;
                            dataWeek.Saturday[11].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[11].Up += data.Up;
                            dataWeek.Sunday[11].Down += data.Down;
                        }
                        break;
                    case 12:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[12].Up += data.Up;
                            dataWeek.Monday[12].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[12].Up += data.Up;
                            dataWeek.Tuesday[12].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[12].Up += data.Up;
                            dataWeek.Wednesday[12].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[12].Up += data.Up;
                            dataWeek.Thursday[12].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[12].Up += data.Up;
                            dataWeek.Friday[12].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[12].Up += data.Up;
                            dataWeek.Saturday[12].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[12].Up += data.Up;
                            dataWeek.Sunday[12].Down += data.Down;
                        }
                        break;
                    case 13:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[13].Up += data.Up;
                            dataWeek.Monday[13].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[13].Up += data.Up;
                            dataWeek.Tuesday[13].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[13].Up += data.Up;
                            dataWeek.Wednesday[13].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[13].Up += data.Up;
                            dataWeek.Thursday[13].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[13].Up += data.Up;
                            dataWeek.Friday[13].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[13].Up += data.Up;
                            dataWeek.Saturday[13].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[13].Up += data.Up;
                            dataWeek.Sunday[13].Down += data.Down;
                        }
                        break;
                    case 14:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[14].Up += data.Up;
                            dataWeek.Monday[14].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[14].Up += data.Up;
                            dataWeek.Tuesday[14].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[14].Up += data.Up;
                            dataWeek.Wednesday[14].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[14].Up += data.Up;
                            dataWeek.Thursday[14].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[14].Up += data.Up;
                            dataWeek.Friday[14].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[14].Up += data.Up;
                            dataWeek.Saturday[14].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[14].Up += data.Up;
                            dataWeek.Sunday[14].Down += data.Down;
                        }
                        break;
                    case 15:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[15].Up += data.Up;
                            dataWeek.Monday[15].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[15].Up += data.Up;
                            dataWeek.Tuesday[15].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[15].Up += data.Up;
                            dataWeek.Wednesday[15].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[15].Up += data.Up;
                            dataWeek.Thursday[15].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[15].Up += data.Up;
                            dataWeek.Friday[15].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[15].Up += data.Up;
                            dataWeek.Saturday[15].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[15].Up += data.Up;
                            dataWeek.Sunday[15].Down += data.Down;
                        }
                        break;
                    case 16:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[16].Up += data.Up;
                            dataWeek.Monday[16].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[16].Up += data.Up;
                            dataWeek.Tuesday[16].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[16].Up += data.Up;
                            dataWeek.Wednesday[16].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[16].Up += data.Up;
                            dataWeek.Thursday[16].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[16].Up += data.Up;
                            dataWeek.Friday[16].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[16].Up += data.Up;
                            dataWeek.Saturday[16].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[16].Up += data.Up;
                            dataWeek.Sunday[16].Down += data.Down;
                        }
                        break;
                    case 17:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[17].Up += data.Up;
                            dataWeek.Monday[17].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[17].Up += data.Up;
                            dataWeek.Tuesday[17].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[17].Up += data.Up;
                            dataWeek.Wednesday[17].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[17].Up += data.Up;
                            dataWeek.Thursday[17].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[17].Up += data.Up;
                            dataWeek.Friday[17].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[17].Up += data.Up;
                            dataWeek.Saturday[17].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[17].Up += data.Up;
                            dataWeek.Sunday[17].Down += data.Down;
                        }
                        break;
                    case 18:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[18].Up += data.Up;
                            dataWeek.Monday[18].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[18].Up += data.Up;
                            dataWeek.Tuesday[18].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[18].Up += data.Up;
                            dataWeek.Wednesday[18].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[18].Up += data.Up;
                            dataWeek.Thursday[18].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[18].Up += data.Up;
                            dataWeek.Friday[18].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[18].Up += data.Up;
                            dataWeek.Saturday[18].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[18].Up += data.Up;
                            dataWeek.Sunday[18].Down += data.Down;
                        }
                        break;
                    case 19:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[19].Up += data.Up;
                            dataWeek.Monday[19].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[19].Up += data.Up;
                            dataWeek.Tuesday[19].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[19].Up += data.Up;
                            dataWeek.Wednesday[19].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[19].Up += data.Up;
                            dataWeek.Thursday[19].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[19].Up += data.Up;
                            dataWeek.Friday[19].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[19].Up += data.Up;
                            dataWeek.Saturday[19].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[19].Up += data.Up;
                            dataWeek.Sunday[19].Down += data.Down;
                        }
                        break;
                    case 20:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[20].Up += data.Up;
                            dataWeek.Monday[20].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[20].Up += data.Up;
                            dataWeek.Tuesday[20].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[20].Up += data.Up;
                            dataWeek.Wednesday[20].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[20].Up += data.Up;
                            dataWeek.Thursday[20].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[20].Up += data.Up;
                            dataWeek.Friday[20].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[20].Up += data.Up;
                            dataWeek.Saturday[20].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[20].Up += data.Up;
                            dataWeek.Sunday[20].Down += data.Down;
                        }
                        break;
                    case 21:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[21].Up += data.Up;
                            dataWeek.Monday[21].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[21].Up += data.Up;
                            dataWeek.Tuesday[21].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[21].Up += data.Up;
                            dataWeek.Wednesday[21].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[21].Up += data.Up;
                            dataWeek.Thursday[21].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[21].Up += data.Up;
                            dataWeek.Friday[21].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[21].Up += data.Up;
                            dataWeek.Saturday[21].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[21].Up += data.Up;
                            dataWeek.Sunday[21].Down += data.Down;
                        }
                        break;
                    case 22:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[22].Up += data.Up;
                            dataWeek.Monday[22].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[22].Up += data.Up;
                            dataWeek.Tuesday[22].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[22].Up += data.Up;
                            dataWeek.Wednesday[22].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[22].Up += data.Up;
                            dataWeek.Thursday[22].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[22].Up += data.Up;
                            dataWeek.Friday[22].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[22].Up += data.Up;
                            dataWeek.Saturday[22].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[22].Up += data.Up;
                            dataWeek.Sunday[22].Down += data.Down;
                        }
                        break;
                    case 23:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            dataWeek.Monday[23].Up += data.Up;
                            dataWeek.Monday[23].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            dataWeek.Tuesday[23].Up += data.Up;
                            dataWeek.Tuesday[23].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            dataWeek.Wednesday[23].Up += data.Up;
                            dataWeek.Wednesday[23].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            dataWeek.Thursday[23].Up += data.Up;
                            dataWeek.Thursday[23].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            dataWeek.Friday[23].Up += data.Up;
                            dataWeek.Friday[23].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dataWeek.Saturday[23].Up += data.Up;
                            dataWeek.Saturday[23].Down += data.Down;
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dataWeek.Sunday[23].Up += data.Up;
                            dataWeek.Sunday[23].Down += data.Down;
                        }
                        break;
                }

            }
            return dataWeek;
        }
        public static DateTime DataWeekStart()
        {
            var sevenDaysBefore = DateTime.Now.AddDays(-7);
            DateTime usableDate = sevenDaysBefore.Date.Add(new TimeSpan(sevenDaysBefore.Hour, 59, 59));
            return usableDate;
        }
        public static BatteryWeek CrunchLastWeekBatteryData(List<Battery> weekOldData)
        {
            var batteryWeek = new BatteryWeek();

            var mondayZero = new List<float>();
            var mondayFour = new List<float>();
            var mondayEight = new List<float>();
            var mondayTwelve = new List<float>();
            var mondaySixteen = new List<float>();
            var mondayTwenty = new List<float>();

            var tuesdayZero = new List<float>();
            var tuesdayFour = new List<float>();
            var tuesdayEight = new List<float>();
            var tuesdayTwelve = new List<float>();
            var tuesdaySixteen = new List<float>();
            var tuesdayTwenty = new List<float>();

            var wednesdayZero = new List<float>();
            var wednesdayFour = new List<float>();
            var wednesdayEight = new List<float>();
            var wednesdayTwelve = new List<float>();
            var wednesdaySixteen = new List<float>();
            var wednesdayTwenty = new List<float>();

            var thursdayZero = new List<float>();
            var thursdayFour = new List<float>();
            var thursdayEight = new List<float>();
            var thursdayTwelve = new List<float>();
            var thursdaySixteen = new List<float>();
            var thursdayTwenty = new List<float>();

            var fridayZero = new List<float>();
            var fridayFour = new List<float>();
            var fridayEight = new List<float>();
            var fridayTwelve = new List<float>();
            var fridaySixteen = new List<float>();
            var fridayTwenty = new List<float>();

            var saturdayZero = new List<float>();
            var saturdayFour = new List<float>();
            var saturdayEight = new List<float>();
            var saturdayTwelve = new List<float>();
            var saturdaySixteen = new List<float>();
            var saturdayTwenty = new List<float>();

            var sundayZero = new List<float>();
            var sundayFour = new List<float>();
            var sundayEight = new List<float>();
            var sundayTwelve = new List<float>();
            var sundaySixteen = new List<float>();
            var sundayTwenty = new List<float>();

            foreach (Battery data in weekOldData)
            {
                switch (data.DateTime.Hour)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            mondayZero.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            tuesdayZero.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            wednesdayZero.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            thursdayZero.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            fridayZero.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            saturdayZero.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            sundayZero.Add(data.Voltage);
                        }
                        break;
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            mondayFour.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            tuesdayFour.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            wednesdayFour.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            thursdayFour.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            fridayFour.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            saturdayFour.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            sundayFour.Add(data.Voltage);
                        }
                        break;
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            mondayEight.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            tuesdayEight.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            wednesdayEight.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            thursdayEight.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            fridayEight.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            saturdayEight.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            sundayEight.Add(data.Voltage);
                        }
                        break;
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            mondayTwelve.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            tuesdayTwelve.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            wednesdayTwelve.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            thursdayTwelve.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            fridayTwelve.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            saturdayTwelve.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            sundayTwelve.Add(data.Voltage);
                        }
                        break;
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            mondaySixteen.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            tuesdaySixteen.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            wednesdaySixteen.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            thursdaySixteen.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            fridaySixteen.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            saturdaySixteen.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            sundaySixteen.Add(data.Voltage);
                        }
                        break;
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                        if (data.DateTime.DayOfWeek == DayOfWeek.Monday)
                        {
                            mondayTwenty.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            tuesdayTwenty.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            wednesdayTwenty.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Thursday)
                        {
                            thursdayTwenty.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Friday)
                        {
                            fridayTwenty.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Saturday)
                        {
                            saturdayTwenty.Add(data.Voltage);
                        }
                        if (data.DateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            sundayTwenty.Add(data.Voltage);
                        }
                        break;
                }
            }
            batteryWeek.Monday[0] = mondayZero.Count() > 0 ? mondayZero.Average() : 0;
            batteryWeek.Tuesday[0] = tuesdayZero.Count() > 0 ? tuesdayZero.Average() : 0;
            batteryWeek.Wednesday[0] = wednesdayZero.Count() > 0 ? wednesdayZero.Average() : 0;
            batteryWeek.Thursday[0] = thursdayZero.Count() > 0 ? thursdayZero.Average() : 0;
            batteryWeek.Friday[0] = fridayZero.Count() > 0 ? fridayZero.Average() : 0;
            batteryWeek.Saturday[0] = saturdayZero.Count() > 0 ? saturdayZero.Average() : 0;
            batteryWeek.Sunday[0] = sundayZero.Count() > 0 ? sundayZero.Average() : 0;

            batteryWeek.Monday[1] = mondayFour.Count() > 0 ? mondayFour.Average() : 0;
            batteryWeek.Tuesday[1] = tuesdayFour.Count() > 0 ? tuesdayFour.Average() : 0;
            batteryWeek.Wednesday[1] = wednesdayFour.Count() > 0 ? wednesdayFour.Average() : 0;
            batteryWeek.Thursday[1] = thursdayFour.Count() > 0 ? thursdayFour.Average() : 0;
            batteryWeek.Friday[1] = fridayFour.Count() > 0 ? fridayFour.Average() : 0;
            batteryWeek.Saturday[1] = saturdayFour.Count() > 0 ? saturdayFour.Average() : 0;
            batteryWeek.Sunday[1] = sundayFour.Count() > 0 ? sundayFour.Average() : 0;

            batteryWeek.Monday[2] = mondayEight.Count() > 0 ? mondayEight.Average() : 0;
            batteryWeek.Tuesday[2] = tuesdayEight.Count() > 0 ? tuesdayEight.Average() : 0;
            batteryWeek.Wednesday[2] = wednesdayEight.Count() > 0 ? wednesdayEight.Average() : 0;
            batteryWeek.Thursday[2] = thursdayEight.Count() > 0 ? thursdayEight.Average() : 0;
            batteryWeek.Friday[2] = fridayEight.Count() > 0 ? fridayEight.Average() : 0;
            batteryWeek.Saturday[2] = saturdayEight.Count() > 0 ? saturdayEight.Average() : 0;
            batteryWeek.Sunday[2] = sundayEight.Count() > 0 ? sundayEight.Average() : 0;

            batteryWeek.Monday[3] = mondayTwelve.Count() > 0 ? mondayTwelve.Average() : 0;
            batteryWeek.Tuesday[3] = tuesdayTwelve.Count() > 0 ? tuesdayTwelve.Average() : 0;
            batteryWeek.Wednesday[3] = wednesdayTwelve.Count() > 0 ? wednesdayTwelve.Average() : 0;
            batteryWeek.Thursday[3] = thursdayTwelve.Count() > 0 ? thursdayTwelve.Average() : 0;
            batteryWeek.Friday[3] = fridayTwelve.Count() > 0 ? fridayTwelve.Average() : 0;
            batteryWeek.Saturday[3] = saturdayTwelve.Count() > 0 ? saturdayTwelve.Average() : 0;
            batteryWeek.Sunday[3] = sundayTwelve.Count() > 0 ? sundayTwelve.Average() : 0;

            batteryWeek.Monday[4] = mondaySixteen.Count() > 0 ? mondaySixteen.Average() : 0;
            batteryWeek.Tuesday[4] = tuesdaySixteen.Count() > 0 ? tuesdaySixteen.Average() : 0;
            batteryWeek.Wednesday[4] = wednesdaySixteen.Count() > 0 ? wednesdaySixteen.Average() : 0;
            batteryWeek.Thursday[4] = thursdaySixteen.Count() > 0 ? thursdaySixteen.Average() : 0;
            batteryWeek.Friday[4] = fridaySixteen.Count() > 0 ? fridaySixteen.Average() : 0;
            batteryWeek.Saturday[4] = saturdaySixteen.Count() > 0 ? saturdaySixteen.Average() : 0;
            batteryWeek.Sunday[4] = sundaySixteen.Count() > 0 ? sundaySixteen.Average() : 0;

            batteryWeek.Monday[5] = mondayTwenty.Count() > 0 ? mondayTwenty.Average() : 0;
            batteryWeek.Tuesday[5] = tuesdayTwenty.Count() > 0 ? tuesdayTwenty.Average() : 0;
            batteryWeek.Wednesday[5] = wednesdayTwenty.Count() > 0 ? wednesdayTwenty.Average() : 0;
            batteryWeek.Thursday[5] = thursdayTwenty.Count() > 0 ? thursdayTwenty.Average() : 0;
            batteryWeek.Friday[5] = fridayTwenty.Count() > 0 ? fridayTwenty.Average() : 0;
            batteryWeek.Saturday[5] = saturdayTwenty.Count() > 0 ? saturdayTwenty.Average() : 0;
            batteryWeek.Sunday[5] = sundayTwenty.Count() > 0 ? sundayTwenty.Average() : 0;
            return batteryWeek;
        }
        public static DateTime BatteryWeekStart()
        {

            var sevenDaysBefore = DateTime.Now.AddDays(-7);
            DateTime usableDate;
            if ((sevenDaysBefore.Hour) % 4 == 0)
            {
                usableDate = sevenDaysBefore.Date.Add(new TimeSpan(sevenDaysBefore.Hour + 3, 59, 59));
            }
            else if ((sevenDaysBefore.Hour + 1) % 4 == 0)
            {
                usableDate = sevenDaysBefore.Date.Add(new TimeSpan(sevenDaysBefore.Hour, 59, 59));
            }
            else if ((sevenDaysBefore.Hour + 1) % 4 == 0)
            {
                usableDate = sevenDaysBefore.Date.Add(new TimeSpan(sevenDaysBefore.Hour + 1, 59, 59));
            }
            else
            {
                usableDate = sevenDaysBefore.Date.Add(new TimeSpan(sevenDaysBefore.Hour + 2, 59, 59));
            }
            return usableDate;
        }
    }
}