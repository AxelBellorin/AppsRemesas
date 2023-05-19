using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using Android.Content;
using AppsRemesas.Activities;

namespace AppsRemesas
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lv_Year;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);


            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Activity_Main);

            lv_Year = FindViewById<ListView>(Resource.Id.lv_year);
            lv_Year.Adapter = new Adapter_Year(this, Global.year, Global.mes);
            lv_Year.ItemClick += lv_Year_ItemClick;
        }

        private void lv_Year_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent intent = new Intent(this, typeof(Activity_Meses));

            int id_year = Global.year[e.Position].Id;

            intent.PutExtra("id_year", id_year);
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}