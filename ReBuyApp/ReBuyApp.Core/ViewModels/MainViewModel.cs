using MvvmCross.Core.ViewModels;
using ReBuyApp.Core.Common.Dialogs;
using ReBuyApp.Core.Common.Tracking.Services;

namespace ReBuyApp.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public void ShowMenu()
        {
            ShowViewModel<MenuViewModel>();
        }

        public MainViewModel(
            IAnalyticsService tracker,
            IDialogService dialogService
        ) : base(tracker, dialogService)
        {
            //HamburgerMenuNavigationCommand = new MvxCommand<int>(NavigateToViewModel);
            //SearchCommand = new MvxCommand(ExecuteSearch);
            //GoToUserProfileCommand = new MvxCommad(MyAccount);
        }
    }
}
