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
using Android.Widget;

namespace AppsRemesas
{
    [Activity(Label = "Actividad_Detalle_Meses")]
    public class Actividad_Detalle_Meses : Activity
    {
        TextView tv_detalle_Mes;
        TextView tv_Detalle_year;
        TextView tv_Detalle_Cantidad_Remesas;
        TextView tv_Detalle_Ranking;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Detalle_Meses);

            tv_detalle_Mes = FindViewById<TextView>(Resource.Id.tv_detalle_Mes);
            tv_Detalle_year = FindViewById<TextView>(Resource.Id.tv_Detalle_year);
            tv_Detalle_Cantidad_Remesas = FindViewById<TextView>(Resource.Id.tv_Detalle_Cantidad_Remesas);
            tv_Detalle_Ranking = FindViewById<TextView>(Resource.Id.tv_Detalle_Ranking);

            int id_mes = Intent.GetIntExtra("id_mes",0);
            int id_year = Intent.GetIntExtra("id_year", 0);

            tv_detalle_Mes.Text = Global.mes.Where(x => x.Id == id_mes).Single().Nombre;
            tv_Detalle_year.Text = Global.year.Where(x => x.Id == id_year).Single().Years.ToString();
            tv_Detalle_Cantidad_Remesas.Text = GetString(Resource.String.cantidad_remesas) + " " + (Global.conversion_Millones(Global.mes.Where(mes => mes.Id_Year == id_year).Sum(x => x.Cantidad_Remesa)) + " $");
            tv_Detalle_Ranking.Text = GetString(Resource.String.ranking) + " " + Global.ranking(Global.mes.Where(x=>x.Id_Year == id_year).ToList(), id_mes).ToString();

        }
    }
}