using Android.App;
using Android.OS;
using Android.Views;
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
    public class MainActivity : ListActivity
    {
        #region Private Fields

        private string _apiKey = "wTfjFu9U1bQzllguURBCG9qx53zLVuEQ";
        private string[] _items;

        #endregion Private Fields

        #region Protected Methods

        protected override void OnCreate(Bundle savedInstanceState)
        {
            Console.WriteLine("OnCreate");
            base.OnCreate(savedInstanceState);

            string query = "wa";

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://dataservice.accuweather.com");
                    string jsonResult = client.GetStringAsync($"locations/v1/cities/autocomplete?apikey={_apiKey}&q={query}").Result;

                    _items = JsonConvert
                        .DeserializeObject<List<City>>(jsonResult)
                        .Select(x => x.LocalizedName)
                        .ToArray();

                    ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, _items);
                }
            }
            catch (Exception ex)
            {
                ShowToast(ex.Message);
            }
        }

        protected override void OnDestroy()
        {
            Console.WriteLine("OnDestroy");
            base.OnDestroy();
        }

        protected override void OnListItemClick(ListView list, View view, int position, long id)
        {
            var text = _items[position];
            ShowToast(text);
        }

        protected override void OnPause()
        {
            Console.WriteLine("OnPause");
            base.OnPause();
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
            base.OnResume();
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");
            base.OnStart();
        }

        protected override void OnStop()
        {
            Console.WriteLine("OnStop");
            base.OnStop();
        }

        #endregion Protected Methods

        #region Private Methods

        private void ShowToast(string message)
        {
            Toast.MakeText(this, message, ToastLength.Short).Show();
        }

        #endregion Private Methods
    }
}