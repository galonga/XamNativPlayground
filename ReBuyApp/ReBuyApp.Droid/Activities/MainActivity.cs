using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Views.InputMethods;
using ReBuyApp.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using RebuyApp.Droid.Common.Tracking.Services;
using CrashManager = HockeyApp.Android.CrashManager;
using HockeyApp.Android.Metrics;

namespace ReBuyApp.Droid.Activities
{
    [Activity(
        Label = "ReBuyApp.Droid",
        Icon = "@drawable/icon",
        Theme = "@style/AppTheme",
        LaunchMode = LaunchMode.SingleTop
    )]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>, INavigationActivity
    {
        public DrawerLayout Drawer { get; set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //HockeyApp Registratio
            CrashManager.Register(this, "3781ea023ebb4f6290c6f587aae44b44");
            MetricsManager.Register(Application, "3781ea023ebb4f6290c6f587aae44b44");

            //Google Analytics Init
            var ga = AnalyticsService.GetGASInstance();
            ga.Init("UA-87598000-1", this, 5);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

            if (bundle == null)
                ViewModel.ShowMenu();
        }

        public override void OnBeforeFragmentChanging(MvvmCross.Droid.Shared.Caching.IMvxCachedFragmentInfo fragmentInfo, Android.Support.V4.App.FragmentTransaction transaction)
        {
            transaction.SetCustomAnimations(
                Resource.Animation.abc_fade_in,
                Resource.Animation.abc_fade_out,
                Resource.Animation.abc_fade_in,
                Resource.Animation.abc_fade_out);

            base.OnBeforeFragmentChanging(fragmentInfo, transaction);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId) {
                case Android.Resource.Id.Home:
                    Drawer.OpenDrawer(GravityCompat.Start);
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }

        public override void OnBackPressed()
        {
            if (Drawer != null && Drawer.IsDrawerOpen(GravityCompat.Start))
                Drawer.CloseDrawers();
            else
                Finish();
        }

        public void HideSoftKeyboard()
        {
            if (CurrentFocus == null) return;

            InputMethodManager inputMethodManager = (InputMethodManager)GetSystemService(InputMethodService);
            inputMethodManager.HideSoftInputFromWindow(CurrentFocus.WindowToken, 0);

            CurrentFocus.ClearFocus();
        }
    }

    public interface INavigationActivity
    {
        DrawerLayout Drawer { get; set; }
        void HideSoftKeyboard();
    }
}
