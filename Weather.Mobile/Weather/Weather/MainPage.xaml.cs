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

            // I couldn't find a way to set the semi-transparent color in XAML
            busyBackground.BackgroundColor = new Color(0, 0, 0, 0.5);
        }
    }


    public class DataContext
    {
        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;                
            }
        }

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
