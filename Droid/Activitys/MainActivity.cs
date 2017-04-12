using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using RebuyApp.ViewModels.Common;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;

namespace RebuyApp.Droid.Activitys
{
    [Activity(
        Label = "Rebuy",
        MainLauncher = true,
        Theme = "@style/ReBuyTheme",
        Icon = "@mipmap/icon"
    )]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //HockeyApp Registration
            CrashManager.Register(this, "3781ea023ebb4f6290c6f587aae44b44");
            MetricsManager.Register(Application, "3781ea023ebb4f6290c6f587aae44b44");

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }
    }
}

