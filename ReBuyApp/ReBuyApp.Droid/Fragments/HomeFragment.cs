using ReBuyApp.Core.ViewModels;
using MvvmCross.Droid.Shared.Attributes;

namespace ReBuyApp.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    public class HomeFragment : BaseFragment<HomeViewModel>
    {
        protected override int FragmentId => Resource.Layout.fragment_home;
    }
}