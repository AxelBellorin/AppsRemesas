using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
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
        List<Meses> meses;

        public Adapter_Year(Activity context, List<Year> year, List<Meses> meses)
        {
            this.context = context;
            this.year = year;
            this.meses = meses;
        }

        public override int Count => year.Count;

        public Drawable GetDrawable { get; private set; }

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
                view = context.LayoutInflater.Inflate(Resource.Layout.Fila_Year, null);

            view.FindViewById<TextView>(Resource.Id.tv_year).Text = "Año: " + item.Years.ToString();
            view.FindViewById<TextView>(Resource.Id.tv_promedio).Text = "Promedio: " + Global.conversion_Millones(meses.Where(x=>x.Id_Year == item.Id).Average(x=>x.Cantidad_Remesa));


            return view;
        }
    }
}