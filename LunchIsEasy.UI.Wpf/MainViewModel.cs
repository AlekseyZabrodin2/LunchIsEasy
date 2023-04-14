using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore.Storage;
using Prism.Commands;
using Prism.Mvvm;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace LunchIsEasy.UI.Wpf
{
    public class MainViewModel : BindableBase
    {
       


        private PageAuthorization _getApplicationContent;
        public PageAuthorization GetApplicationContent => _getApplicationContent = new PageAuthorization();





        private DelegateCommand _toRegistrationWindow;
        public ICommand ToRegistrationWindow => _toRegistrationWindow = new DelegateCommand(PerformGoToRegistrationWindow);

        private void PerformGoToRegistrationWindow()
        {
            PageRegistration registration = new PageRegistration();
            Application.Current.MainWindow.Content = registration;
        }


        private RelayCommand _toAuthorizationWindow;
        public RelayCommand ToAuthorizationWindow => _toAuthorizationWindow = new RelayCommand(PerformGoToAuthorizationWindow);

        private void PerformGoToAuthorizationWindow()
        {
            var authorizationPage = new PageAuthorization();
            Application.Current.MainWindow.Content = authorizationPage;
        }












    }
}
