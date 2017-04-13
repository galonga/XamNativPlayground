using Android.App;
using Android.Content.PM;
using Android.Views.Animations;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace ReBuyApp.Droid
{
    [Activity(
        Label = "reBuy X-Native"
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
