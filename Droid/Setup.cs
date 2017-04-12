using System;
using System.Collections.Generic;
using System.Reflection;
using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Shared.Presenter;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;
using RebuyApp.Common.Dialogs;
using RebuyApp.Common.Tracking.Services;
using RebuyApp.Droid.Common.Dialogs.Services;
using RebuyApp.Droid.Common.Tracking.Services;

namespace RebuyApp.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new RebuyApp.App();
        }

        //Android-Specific IOC Registrations
        protected override void InitializeIoC()
        {
            base.InitializeIoC();
        }

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();
            Mvx.ConstructAndRegisterSingleton<IDialogService, DialogService>();
            //Mvx.ConstructAndRegisterSingleton<IShareService, ShareService>();
            Mvx.ConstructAndRegisterSingleton<IAnalyticsService, AnalyticsService>();
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var mvxFragmentsPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);
            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentsPresenter);
            return mvxFragmentsPresenter;
        }

        protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies)
        {
            typeof(Android.Support.V7.Widget.Toolbar).Assembly,
            typeof(Android.Support.V4.Widget.DrawerLayout).Assembly,
            typeof(Android.Support.V4.View.ViewPager).Assembly,
        };
    }
}