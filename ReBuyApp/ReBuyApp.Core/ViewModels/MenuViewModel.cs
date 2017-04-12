using MvvmCross.Core.ViewModels;

namespace ReBuyApp.Core.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public void Navigate<TViewModel>() where TViewModel : class, IMvxViewModel
        {
            ShowViewModel<TViewModel>();
        }
    }
}
