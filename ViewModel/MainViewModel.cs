using CommunityToolkit.Mvvm.Input;
using ControlzEx.Standard;
using LunchIsEasy.UI.Wpf.Model;
using LunchIsEasy.UI.Wpf.Model.Data;
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
using System.Windows.Navigation;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace LunchIsEasy.UI.Wpf
{
    public class MainViewModel : BindableBase
    {

        private string _name = "Name";
        private string _surname = "Surname";
        private string _telephone = "Telephone";
        private string _login = "Login";
        private string _password = "Password";
        private string _repeatPassword = "Repeat password";



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



        private RelayCommand _toRegisterAccount;
        public RelayCommand ToRegisterAccount => _toRegisterAccount = new RelayCommand(PerformGoToRegisterAccount);

        private void PerformGoToRegisterAccount()
        {               
            AccountDBCommand.RegisterAccount(_name, _surname, _telephone, _login, _password, _repeatPassword);

            ClearFields();
        }



        private RelayCommand _toClearFields;
        public RelayCommand ToClearFields => _toClearFields = new RelayCommand(ClearFields);

        public void ClearFields()
        {
            SetName = "Name";
            SetSurname = "Surname";
            SetTelephone = "Telephone";
            SetLogin = "Login";
            SetPassword = "Password";
            SetRepeatPassword = "Repeat password";
        }



    }
}
