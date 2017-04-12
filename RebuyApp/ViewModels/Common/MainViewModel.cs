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
            //GoToUserProfileCommand = new MvxCommand(MyAccount);
        }

        public void NavigateToViewModel(int index)
        {
            switch (index) {
                //case 0:
                //    ShowViewModel<BlueStartViewModel>();
                //    break;
                //case 1:
                //    ShowViewModel<GreenStartViewModel();
                //    break;
                //case 2:
                //    ShowViewModel<BuyAlertViewModel>();
                //    break;
                //case 3:
                //    ShowViewModel<WishListViewModel();
                //    break;
                //case 4:
                //    ShowViewModel<Notific();
                //    break;
                //case 5:
                //    ShowViewModel<SettingsViewModel>();
                //    break;
            }
        }
    }
}
