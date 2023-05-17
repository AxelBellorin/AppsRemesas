using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppsRemesas
{
    class Adapter_Year : BaseAdapter
    {

        Activity context;
        List<year> years;

        public Adapter_Year(Activity context, List<year> years)
        {
            this.context = context;
            this.years = years;
        }

        public override int Count => years.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = years[position];

            View view = convertView;

            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Years.ToString();

            return view;
        }
    }
}