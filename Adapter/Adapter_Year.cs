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
        List<Year> year;

        public Adapter_Year(Activity context, List<Year> year)
        {
            this.context = context;
            this.year = year;
        }

        public override int Count => year.Count;

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
            var item = year[position];

            View view = convertView;

            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Years.ToString();

            return view;
        }
    }
}