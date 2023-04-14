using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LunchIsEasy.UI.Wpf
{
    /// <summary>
    /// Interaction logic for AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }


        public void OnLoginTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text == "User Name")
            {
                LoginTextBox.Text = string.Empty;
                LoginTextBox.Foreground = Brushes.Gray;
                LoginTextBox.CaretIndex = 0;
            }
        }


        public void OnLoginTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                LoginTextBox.Text = "User Name";
                LoginTextBox.Foreground = Brushes.Gray;
            }
        }


        public void OnPasswordTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text == "Password")
            {
                PasswordTextBox.Text = string.Empty;
                PasswordTextBox.Foreground = Brushes.Gray;
                PasswordTextBox.CaretIndex = 0;
            }
        }


        public void OnPasswordTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                PasswordTextBox.Text = "Password";
                PasswordTextBox.Foreground = Brushes.Gray;
            }
        }



        //public void PerformGoToRegistrationWindow1(object sender, RoutedEventArgs e)
        //{
        //    authorization.Navigate(new PageRegistration());
        //}


    }
}
