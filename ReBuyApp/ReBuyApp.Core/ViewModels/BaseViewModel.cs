using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Localization;
using MvvmCross.Platform;
using ReBuyApp.Core.Common.Dialogs;
using ReBuyApp.Core.Common.Tracking.Services;

namespace ReBuyApp.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel, IDisposable
    {
        public IMvxTextProvider TextProvider { get; }
        protected IAnalyticsService Tracker;
        protected readonly IDialogService DialogService;

        public BaseViewModel(
            IAnalyticsService tracker,
            IDialogService dialogService
        )
        {
            TextProvider = Mvx.Resolve<IMvxTextProvider>();
            Tracker = tracker;
            DialogService = dialogService;
        }

        public virtual string Title => TextProvider.GetText(Constants.LocalizationNamespace, this.GetType().Name, "title");

        private bool _isLoading = false;

        public bool IsLoading {
            get { return _isLoading; }
            set {
                SetProperty(ref _isLoading, value);
            }
        }

        private bool isRefreshing;

        public virtual bool IsRefreshing {
            get { return isRefreshing; }
            set {
                SetProperty(ref isRefreshing, value);
            }
        }

        public IMvxLanguageBinder TextSource {
            get { return new MvxLanguageBinder(Constants.LocalizationNamespace, GetType().Name); }
        }

        public void Dispose()
        {
            Tracker = null;
        }
    }
}
