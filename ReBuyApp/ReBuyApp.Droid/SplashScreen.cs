using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace ReBuyApp.Droid
{
    [Activity(
        Label = "ReBuyApp.Droid"
        , MainLauncher = true
        , Icon = "@mipmap/ic_launcher"
        , RoundIcon = "@mipmap/ic_launcher_round"
        , Theme = "@style/AppTheme.Splash"
        , NoHistory = true)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
