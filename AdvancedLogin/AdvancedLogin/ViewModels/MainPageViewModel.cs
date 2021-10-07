using AdvancedLogin.Services;
using Prism.Commands;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace AdvancedLogin.ViewModels
{
    class MainPageViewModel: BaseViewModel
    {
        public ICommand LoginCommand { get; }
        IPageDialogService _pageDialog;

        async void OnLogin()
        {
            string CurrentOrientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation().ToString();
            await _pageDialog.DisplayAlertAsync("Logged In", $"Your current orientation is {CurrentOrientation}", "Ok");
        }

        public MainPageViewModel(IPageDialogService pageDialog)
        {
            _pageDialog = pageDialog;
           
            LoginCommand = new Command(OnLogin);
        }
    }
}
