using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using RebuyApp.Common.Dialogs;
using RebuyApp.Common.Tracking.Services;

namespace RebuyApp.ViewModels.Common
{
    public class BaseViewModel : MvxViewModel, IDisposable
    {
        protected IAnalyticsService Tracker;
        protected IMvxMessenger Messenger;
        protected readonly IDialogService DialogService;

        protected BaseViewModel(IAnalyticsService tracker, IMvxMessenger messenger, IDialogService dialogService)
        {
            Tracker = tracker;
            Messenger = messenger;
            DialogService = dialogService;
        }

        public void Dispose()
        {
            Tracker = null;
            Messenger = null;
        }
    }
}
