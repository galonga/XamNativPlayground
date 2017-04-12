using MvvmCross.Core.ViewModels;
using ReBuyApp.Core.Common.Dialogs;
using ReBuyApp.Core.Common.Tracking.Services;

namespace ReBuyApp.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel(
            IAnalyticsService tracker,
            IDialogService dialogService
            ) : base(tracker, dialogService)
        {
        }
    }
}
