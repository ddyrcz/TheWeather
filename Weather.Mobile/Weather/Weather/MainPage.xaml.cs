using System.ComponentModel;

using Xamarin.Forms;

namespace Weather
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            // I couldn't find a way to set the semi-transparent color in XAML
            busyBackground.BackgroundColor = new Color(0, 0, 0, 0.5);
        }

    }
}