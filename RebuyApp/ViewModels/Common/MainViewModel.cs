using System;
using System.Collections.Generic;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using RebuyApp.Common.Dialogs;
using RebuyApp.Common.Tracking.Services;

namespace RebuyApp.ViewModels.Common
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        //private readonly MvxSubscriptionToken loadingStatusMessageToken;
        //private readonly MvxSubscriptionToken appBarHeaderChangeMessageToken;

        private string pageHeader;
        public string PageHeader {
            get { return pageHeader; }
            set {
                pageHeader = value;
                RaisePropertyChanged(() => PageHeader);
            }
        }

        private bool isLoading;
        public bool IsLoading {
            get { return isLoading; }
            set {
                isLoading = value;
                RaisePropertyChanged(() => IsLoading);
            }
        }

        public IEnumerable<string> MenuItems { get; private set; } = new[] { "Option1", "Option2" };

        public ICommand HamburgerMenuNavigationCommand { get; set; }
        public ICommand GoToSettingsCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand GoToUserProfileCommand { get; set; }

        public MainViewModel(IMvxMessenger messenger, IDialogService dialogService, IAnalyticsService tracker) : base(tracker, messenger, dialogService)
        {
            HamburgerMenuNavigationCommand = new MvxCommand<int>(NavigateToViewModel);
            //SearchCommand = new MvxCommand(ExecuteSearch);
            //GoToUserProfileCommand = new MvxCommand(ShowCurrentUserProfile);
        }

        public void NavigateToViewModel(int index)
        {
            switch (index) {
                //case 0:
                //    ShowViewModel<EventsViewModel>();
                //    break;
                //case 1:
                //    ShowViewModel<NotificationsViewModel>();
                //    break;
                //case 2:
                //    ShowViewModel<SettingsViewModel>();
                //    break;
            }
        }
    }
}
