using Android.App;
using Android.OS;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Weather.Droid.Models;

namespace Weather.Droid
{
    [Activity(Label = "Weather.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private string _apiKey = "wTfjFu9U1bQzllguURBCG9qx53zLVuEQ";

        private AutoCompleteTextView _city;
        private ListView _itemList;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            Console.WriteLine("OnCreate");
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            _itemList = FindViewById<ListView>(Resource.Id.items);
            _city = FindViewById<AutoCompleteTextView>(Resource.Id.city);

            _city.TextChanged += delegate { OnSearch(); };
        }

        private void OnSearch()
        {
            string query = _city?.Text;

            if (query == null) return;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://dataservice.accuweather.com");
                    string jsonResult = client.GetStringAsync($"locations/v1/cities/autocomplete?apikey={_apiKey}&q={query}").Result;

                    var items = JsonConvert
                        .DeserializeObject<List<City>>(jsonResult)
                        .Select(x => x.LocalizedName)
                        .ToArray();

                    ArrayAdapter autoCompleteAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, items);

                    _city.Adapter = autoCompleteAdapter;
                }
            }
            catch (Exception ex)
            {
                ShowToast(ex.Message);
            }
        }

        private void ShowToast(string message)
        {
            Toast.MakeText(this, message, ToastLength.Short).Show();
        }
    }
}