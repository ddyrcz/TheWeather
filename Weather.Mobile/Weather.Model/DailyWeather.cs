using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Model
{
    public class DailyWeather
    {
        private const char DEGREE = '°';

        public DailyWeather(double daytimeTemperature, double nightTemperature)
        {
            DaytimeTemperature = daytimeTemperature;
            NightTemperature = nightTemperature;
        }

        public string DayOfWeek { get; set; }
        public double DaytimeTemperature { get; set; }

        public string DaytimeTemperatureString
        {
            get
            {
                return $"{DaytimeTemperature.ToString()}{DEGREE}";
            }
        }

        public double NightTemperature { get; set; }

        public string NightTemperatureString
        {
            get
            {
                return $"{NightTemperature.ToString()}{DEGREE}";
            }
        }

        public string ShortDayOfWeek { get; set; }

        public string TemperaturesString
        {
            get
            {
                return $"{DaytimeTemperatureString} / {NightTemperatureString}";
            }
        }

        public string WeatherIconPath { get; set; }
    }
}
