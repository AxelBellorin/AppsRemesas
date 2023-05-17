using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppsRemesas.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppsRemesas.Activities
{
    [Activity(Label = "Activity_Meses")]
    public class Activity_Meses : Activity
    {
        TextView year;
        TextView total;
        ListView lv_meses;

        protected override void OnCreate(Bundle savedInstanceState){
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.meses);

            int id_year = Intent.GetIntExtra("id_year", 0);

            year = FindViewById<TextView>(Resource.Id.value_year);
            total = FindViewById<TextView>(Resource.Id.value_total);
            lv_meses = FindViewById<ListView>(Resource.Id.lv_meses);

            year.Text = Global.year.Where(year => year.Id == id_year).Single().Years.ToString();
            total.Text = (Global.conversion_millones(Global.mes.Where(year => year.Id_year == id_year).Sum(x => x.Cantidad_remesa)) + " $");
            lv_meses.Adapter = new Adaptador_Fila_Meses(Global.mes.Where(x => x.Id_year == id_year).ToList(), this);

        }
    }
}   