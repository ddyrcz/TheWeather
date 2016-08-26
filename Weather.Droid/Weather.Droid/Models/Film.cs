using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Weather.Droid.Models
{
    class Films
    {
        public List<Film> results { get; set; }
    }

    class Film
    {
        public int id { get; set; }
        public string title { get; set; }
        public string overview { get; set; }
        public double vote_average { get; set; }
        public string poster_path { get; set; }
        public DateTime release_date { get; set; }
        public string release_year { get { return $"( {release_date.Year} )"; } }
        public string profile_path { get; set; }
        public string title_with_release_date { get { return $"{title} {release_year}"; } }
    }
}