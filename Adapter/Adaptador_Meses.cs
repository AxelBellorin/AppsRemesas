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
    class Adaptador_Meses : BaseAdapter
    {
        Activity context;
        List<Meses> meses;

        public Adaptador_Meses(Activity context, List<Meses> meses)
        {
            this.context = context;
            this.meses = meses;
        }

        public override int Count => meses.Count;

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
            var item = meses[position];

            View view = convertView;

            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2,null);

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Nombre;
            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = Global.conversion_Millones(item.Cantidad_Remesa) + " $";

            return view;

        }
    }
}