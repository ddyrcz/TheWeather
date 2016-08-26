using Android.App;
using Android.Views;
using Android.Widget;

namespace Weather.Droid
{
    internal class ItemAdapter : BaseAdapter<string>
    {
        private Activity context;
        private string[] items;

        public override int Count
        {
            get { return items?.Length ?? 0; }
        }

        public ItemAdapter(Activity context, string[] items) : base()
        {
            this.context = context;
            this.items = items;
        }

        public override string this[int position]
        {
            get { return items?[position]; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView; // re-use an existing view, if one is available
            if (view == null) // otherwise create a new one
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = items[position];
            return view;
        }
    }
}