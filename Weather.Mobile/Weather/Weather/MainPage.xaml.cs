using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Weather
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new DataContext();
        }
    }


    public class DataContext
    {
        const char DEGREE = '°';
        

        public string Location { get; set; } = "Katowice";

        public int CurrentTemperature { get; set; } = 11;


        public string CurrentTemperatureString
        {
            get
            {  
                return CurrentTemperature.ToString() + DEGREE;
            }
        }
    }
}
