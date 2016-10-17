using System;
using Weather.Interface;

namespace Weather.ViewModel
{
    internal class DailyWeather
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

    internal class MainViewModel : BaseViewModel, ISearchable
    {
        private DailyWeather[] _futureWeather = {
            new DailyWeather(5,2) { WeatherIconPath = "cloudy.png",  ShortDayOfWeek = "Tue" } ,
            new DailyWeather(6,1) { WeatherIconPath = "cloudy.png",  ShortDayOfWeek = "Wed"  } ,
            new DailyWeather(8,3) { WeatherIconPath = "cloudy.png",  ShortDayOfWeek = "Thu"  } ,
            new DailyWeather(12,6) { WeatherIconPath = "cloudy.png",  ShortDayOfWeek = "Fri"  }
        };

        private string _query;

        public DailyWeather CurrentWeather { get; set; } = new DailyWeather(2, 1)
        {
            WeatherIconPath = "large_stormy.png",
            DayOfWeek = "Monday"
        };

        public DailyWeather[] FutureWeather
        {
            get { return _futureWeather; }
            set { _futureWeather = value; }
        }

        public string Location { get; set; } = "Katowice";

        public string Query
        {
            get { return _query; }
            set
            {
                _query = value;
                //Search(Query);
            }
        }

        public void Search(string query)
        {
            throw new NotImplementedException();
        }
    }
}