using AdvancedLogin.Services;
using Prism.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace AdvancedLogin.ViewModels
{
    class MainPageViewModel: BaseViewModel
    {
        public ICommand LoginCommand { get; }
        IPageDialogService _pageDialog;

        async void OnLogin()
        {
            string currentOrientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation().ToString();
            await _pageDialog.DisplayAlertAsync("Logged In", $"Your current orientation is {currentOrientation}", "Ok");
        }

        public MainPageViewModel(IPageDialogService pageDialog)
        {
            _pageDialog = pageDialog;
           
            LoginCommand = new Command(OnLogin);
        }
    }
}
