using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Interface;

namespace Weather.ViewModel
{
    class DailyTemperature
    {
        public DailyTemperature(string shortDayOfWeek, double daytimeTemperature, double nightTemperature)
        {
            DaytimeTemperature = daytimeTemperature;
            NightTemperature = nightTemperature;
            ShortDayOfWeek = shortDayOfWeek;
        }

        private const char DEGREE = '°';

        public double DaytimeTemperature { get; set; }


        public string ShortDayOfWeek { get; set; }

        public string WeatherIconPath { get; set; } = "cloudy.png";

        public string Overview
        {
            get
            {
                return $"{DaytimeTemperature.ToString()}{DEGREE} / {NightTemperature.ToString()}{DEGREE}";
            }
        }
    }

    class MainViewModel : BaseViewModel, ISearchable
    {
        private DailyTemperature[] _futureTemperatures = {
            new DailyTemperature("Tue",5,2),
            new DailyTemperature("Wed",6,1),
            new DailyTemperature("Thu",8,3),
            new DailyTemperature("Fri",12,6)
        };

        public string FutureTemperature { get; set; } = "1/1";

        public DailyTemperature[] FutureTemperatures
        {
            get { return _futureTemperatures; }
            set { _futureTemperatures = value; }
        }

        private string _query;

        public string Query
        {
            get { return _query; }
            set
            {
                _query = value;
                //Search(Query);
            }
        }

        private string _currentWeatherIconPath = "large_cloudy.png";

        public string CurrentWeatherIconPath
        {
            get { return _currentWeatherIconPath; }
            set { _currentWeatherIconPath = value; }
        }

        private string _dayOfWeen = "Monday";

        public string DayOfWeek
        {
            get { return _dayOfWeen; }
            set { _dayOfWeen = value; }
        }



        private const char DEGREE = '°';

        public int CurrentTemperature { get; set; } = 11;

        public string CurrentTemperatureString
        {
            get
            {
                return CurrentTemperature.ToString() + DEGREE;
            }
        }

        public string Location { get; set; } = "Katowice";

        public void Search(string query)
        {
            throw new NotImplementedException();
        }
    }
}
