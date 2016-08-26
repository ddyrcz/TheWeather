using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace Weather.Droid
{
    [Activity(Label = "Weather.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        #region Protected Methods

        protected override void OnCreate(Bundle savedInstanceState)
        {
            Console.WriteLine("OnCreate");
            base.OnCreate(savedInstanceState);

            var items = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, items);
        }

        protected override void OnDestroy()
        {
            Console.WriteLine("OnDestroy");
            base.OnDestroy();
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
    }
}