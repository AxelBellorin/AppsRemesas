using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Google.Android.Material.Tabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppsRemesas.Adapter
{
    class Adaptador_Fila_Meses : BaseAdapter<TabItem>
    {
        List<Meses> meses;
        Activity context;

        public Adaptador_Fila_Meses(List<Meses> meses, Activity context)
        {
            this.meses = meses;
            this.context = context;
        }

        public override TabItem this[int position] => throw new NotImplementedException();

        public override int Count => meses.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = meses[position];
            View view = convertView;

            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.fila_adaptador_meses, null);

            view.FindViewById<TextView>(Resource.Id.mes).Text = item.Nombre;
            view.FindViewById<TextView>(Resource.Id.cantidad).Text = Global.conversion_millones(item.Cantidad_remesa) + " $";
            view.FindViewById<TextView>(Resource.Id.value_posicion).Text = Global.ranking(meses, item.Id).ToString();

            return view;
        }
    }
}