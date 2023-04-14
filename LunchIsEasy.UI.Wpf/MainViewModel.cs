using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore.Storage;
using Prism.Commands;
using Prism.Mvvm;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace LunchIsEasy.UI.Wpf
{
    public class MainViewModel : BindableBase
    {
        //public MainViewModel()
        //{
        //    AutorizWindow = new RelayCommand(GoToAutorPage);
        //}

        //MainWindow MainWindow { get; set; }

        //public RelayCommand AutorizWindow { get; }



        //public void GoToAutorPage()
        //{
        //    MainWindow.Content = new AuthorizationPage();
        //}














        public MainWindow mainWindow;


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





        //private RelayCommand _toAuthorizationWindow;
        //public RelayCommand ToAuthorizationWindow => _toAuthorizationWindow = new RelayCommand(PerformGoToAuthorizationWindow);
        //private void PerformGoToAuthorizationWindow()
        //{



        //    mainWindow.DataContext = new AuthorizationPage();


        //}


    }
}
