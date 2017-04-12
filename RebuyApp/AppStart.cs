using System;
using MvvmCross.Core.ViewModels;
using RebuyApp.ViewModels.Common;

namespace RebuyApp
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainViewModel>();
        }
    }
}
