using MvvmCross.Core.ViewModels;

namespace ReBuyApp.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public void ShowMenu()
        {
            ShowViewModel<MenuViewModel>();
        }
    }
}
