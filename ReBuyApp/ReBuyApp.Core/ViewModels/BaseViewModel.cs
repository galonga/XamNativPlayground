using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Localization;
using MvvmCross.Platform;

namespace ReBuyApp.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        public IMvxTextProvider TextProvider { get; }

        public BaseViewModel()
        {
            TextProvider = Mvx.Resolve<IMvxTextProvider>();
        }

        public virtual string Title => TextProvider.GetText(Constants.LocalizationNamespace, this.GetType().Name, "title");

        private bool _isLoading = false;

        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                SetProperty(ref _isLoading, value);
            }
        }

        private bool isRefreshing;

        public virtual bool IsRefreshing
        {
            get { return isRefreshing; }
            set
            {
                SetProperty(ref isRefreshing, value);
            }
        }

        public IMvxLanguageBinder TextSource
        {
            get { return new MvxLanguageBinder(Constants.LocalizationNamespace, GetType().Name); }
        }
    }
}
