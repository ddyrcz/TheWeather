using DarkSkyApi;
using DarkSkyApi.Models;
using System;
using Weather.Interface;
using Weather.Model;

namespace Weather.ViewModel
{    
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
            }
        }

        public MainViewModel()
        {
            var client = new DarkSkyService("918d906b0cf3fc7b2aa3f08dfc4861a5");
            Forecast result = client.GetWeatherDataAsync(37.8267, -122.423).Result;
        }

        

        public void Search(string query)
        {
            // Invoke when
            //  * Click search 
            //  * Click OK on the keyboard
            //  * Select one of the suggestion

            // Get the data from the service
        }
    }
}