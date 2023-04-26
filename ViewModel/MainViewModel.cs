using CommunityToolkit.Mvvm.Input;
using ControlzEx.Standard;
using LunchIsEasy.UI.Wpf.Model;
using LunchIsEasy.UI.Wpf.Model.Data;
using LunchIsEasy.UI.Wpf.View.Pages;
using Microsoft.EntityFrameworkCore.Storage;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace LunchIsEasy.UI.Wpf
{
    public class MainViewModel : BindableBase
    {

        private string _name = string.Empty;
        private string _surname = string.Empty;
        private string _telephone = string.Empty;
        private string _login = string.Empty;
        private string _password = string.Empty;
        private string _repeatPassword = string.Empty;



        private PageAuthorization _getApplicationContent;
        public PageAuthorization GetApplicationContent => _getApplicationContent = new PageAuthorization();



        private List<Accounts> _allAccounts = AccountDBCommand.GetAllAccounts();

        public List<Accounts> Accounts
        {
            get
            {
                return _allAccounts;
            }
            set
            {
                SetProperty(ref _allAccounts, value);
            }
        }



        public string SetName
        {
            get
            {
                return _name;
            }

            set
            {
                SetProperty(ref _name, value);
            }
        }



        public string SetSurname
        {
            get
            {
                return _surname;
            }

            set
            {
                SetProperty(ref _surname, value);
            }
        }



        public string SetTelephone
        {
            get
            {
                return _telephone;
            }

            set
            {
                SetProperty(ref _telephone, value);
            }
        }



        public string SetLogin
        {
            get
            {
                return _login;
            }

            set
            {
                SetProperty(ref _login, value);
            }
        }



        public string SetPassword
        {
            get
            {
                return _password;
            }

            set
            {
                SetProperty(ref _password, value);
            }
        }



        public string SetRepeatPassword
        {
            get
            {
                return _repeatPassword;
            }

            set
            {
                SetProperty(ref _repeatPassword, value);
            }
        }



        private DelegateCommand _toRegistrationWindow;
        public ICommand ToRegistrationWindow => _toRegistrationWindow = new DelegateCommand(PerformGoToRegistrationWindow);

        private void PerformGoToRegistrationWindow()
        {
            ClearingRegistrationPage();

            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("D:\\Develop\\LunchIsEasy\\View\\Sources\\food3.jpg", UriKind.RelativeOrAbsolute));
            Application.Current.MainWindow.Background = newBackground;

            PageRegistration registration = new PageRegistration();
            Application.Current.MainWindow.Content = registration;
        }



        private RelayCommand _toAuthorizationWindow;
        public RelayCommand ToAuthorizationWindow => _toAuthorizationWindow = new RelayCommand(PerformGoToAuthorizationWindow);

        private void PerformGoToAuthorizationWindow()
        {

            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("D:\\Develop\\LunchIsEasy\\View\\Sources\\food2.jpg", UriKind.RelativeOrAbsolute));
            Application.Current.MainWindow.Background = newBackground;

            var authorizationPage = new PageAuthorization();
            Application.Current.MainWindow.Content = authorizationPage;
        }



        private RelayCommand _toRegisterAccount;
        public RelayCommand ToRegisterAccount => _toRegisterAccount = new RelayCommand(PerformGoToRegisterAccount);

        private void PerformGoToRegisterAccount()
        {
            RegisterNewAccount();
        }



        public void ClearingRegistrationPage()
        {
            SetName = string.Empty;
            SetSurname = string.Empty;
            SetTelephone = string.Empty;
            SetLogin = string.Empty;
            SetPassword = string.Empty;
            SetRepeatPassword = string.Empty;
        }


        public void ClearingAuthorizationPage()
        {
            SetLogin = string.Empty;
            SetPassword = string.Empty;
        }




        private bool RegisterNewAccount()
        {
            var register = false;

            if (string.IsNullOrEmpty(_login))
            {
                MessageBox.Show("Enter the Login", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                return register;
            }
            if (string.IsNullOrEmpty(_password))
            {
                MessageBox.Show("Enter the Password", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                return register;
            }
            if (_password != _repeatPassword)
            {
                MessageBox.Show("Invalid password confirmation", "Information", MessageBoxButton.OK, MessageBoxImage.Error);
                SetRepeatPassword = string.Empty;
                return register;
            }

            var registerAccount = AccountDBCommand.RegisterAccount(_name, _surname, _telephone, _login, _password, _repeatPassword);
            if (registerAccount != true)
            {
                SetLogin = string.Empty;
                SetPassword = string.Empty;
                SetRepeatPassword = string.Empty;

                return register;
            }

            ClearingRegistrationPage();

            PageMenuBackground();

            return register = true;
        }



        private RelayCommand _toAuthorizationAccount;
        public RelayCommand ToAuthorizationAccount => _toAuthorizationAccount = new RelayCommand(PerformGoToAuthorizationAccount);

        private void PerformGoToAuthorizationAccount()
        {
            AuthorizationAccount();
        }



        private bool AuthorizationAccount()
        {
            var authorization = false;

            var accountAuthorization = AccountDBCommand.AccountAuthorization(_login, _password);

            if (accountAuthorization)
            {
                PageMenuBackground();

                ClearingAuthorizationPage();

                authorization = true;
            }

            return authorization;
        }

        private static void PageMenuBackground()
        {
            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("D:\\Develop\\LunchIsEasy\\View\\Sources\\food4.jpg", UriKind.RelativeOrAbsolute));
            Application.Current.MainWindow.Background = newBackground;

            Application.Current.MainWindow.Content = new PageMenu();
        }




    }
}
