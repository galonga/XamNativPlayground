using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using MvvmCross.Droid.Support.V7.AppCompat;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using HockeyApp.Android.Metrics;
using CrashManager = HockeyApp.Android.CrashManager;
using SearchView = Android.Support.V7.Widget.SearchView;
using RebuyApp.ViewModels.Common;
using RebuyApp.Droid.Common.Tracking.Services;

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
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //HockeyApp Registration
            CrashManager.Register(this, "3781ea023ebb4f6290c6f587aae44b44");
            MetricsManager.Register(Application, "3781ea023ebb4f6290c6f587aae44b44");

            //Google Analytics Init
            var ga = AnalyticsService.GetGASInstance();
            ga.Init("UA-87598000-1", this, 5);


            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
        }
    }
}

