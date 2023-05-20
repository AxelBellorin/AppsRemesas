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
        ListView lv_Meses;

        protected override void OnCreate(Bundle savedInstanceState){
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Meses);

            int id_year = Intent.GetIntExtra("id_year", 0);

            year = FindViewById<TextView>(Resource.Id.tv_year_month);
            //total = FindViewById<TextView>(Resource.Id.value_total);
            lv_Meses = FindViewById<ListView>(Resource.Id.lv_meses);

            year.Text = GetString(Resource.String.year) + " :" + Global.year.Where(year => year.Id == id_year).Single().Years.ToString();
            lv_Meses.Adapter = new Adaptador_Fila_Meses(Global.mes.Where(x => x.Id_Year == id_year).ToList(), this);


            lv_Meses.ItemClick += Lv_Meses_ItemClick;
        }

        private void Lv_Meses_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent intent = new Intent(this, typeof(Actividad_Detalle_Meses));
            int id_mes = Global.mes[e.Position].Id;
            int id_year = Global.mes[e.Position].Id_Year;
            intent.PutExtra("id_mes", id_mes);
            intent.PutExtra("id_year", id_year);

            StartActivity(intent);
        }
    }
}   