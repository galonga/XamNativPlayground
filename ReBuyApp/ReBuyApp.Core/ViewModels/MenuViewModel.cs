using MvvmCross.Core.ViewModels;
using ReBuyApp.Core.Common.Dialogs;
using ReBuyApp.Core.Common.Tracking.Services;

namespace ReBuyApp.Core.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public void Navigate<TViewModel>() where TViewModel : class, IMvxViewModel
        {
            ShowViewModel<TViewModel>();
        }

        public MenuViewModel(
            IAnalyticsService tracker,
            IDialogService dialogService
        ) : base(tracker, dialogService)
        {

        }
    }
}
