using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LunchIsEasy.UI.Wpf
{
    /// <summary>
    /// Interaction logic for PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration
    {
        public PageRegistration()
        {
            InitializeComponent();
        }




        public void OnNameTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text == "Name")
            {
                NameTextBox.Text = string.Empty;
                NameTextBox.Foreground = Brushes.Black;
                NameTextBox.CaretIndex = 0;
            }
        }


        public void OnNameTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                NameTextBox.Text = "Name";
                NameTextBox.Foreground = Brushes.Gray;
            }
        }


        public void OnSurnameTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            if (SurnameTextBox.Text == "Surname")
            {
                SurnameTextBox.Text = string.Empty;
                SurnameTextBox.Foreground = Brushes.Black;
                SurnameTextBox.CaretIndex = 0;
            }
        }


        public void OnSurnameTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SurnameTextBox.Text))
            {
                SurnameTextBox.Text = "Surname";
                SurnameTextBox.Foreground = Brushes.Gray;
            }
        }


        public void OnTelephoneTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            if (TelephoneTextBox.Text == "Telephone")
            {
                TelephoneTextBox.Text = "+375";
                TelephoneTextBox.Foreground = Brushes.Black;
                TelephoneTextBox.CaretIndex = 0;
            }
        }


        public void OnTelephoneTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (TelephoneTextBox.Text == "+375" || string.IsNullOrWhiteSpace(TelephoneTextBox.Text))
            {
                TelephoneTextBox.Text = "Telephone";
                TelephoneTextBox.Foreground = Brushes.Gray;
            }
        }


        public void OnLoginTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text == "Login")
            {
                LoginTextBox.Text = string.Empty;
                LoginTextBox.Foreground = Brushes.Black;
                LoginTextBox.CaretIndex = 0;
            }
        }


        public void OnLoginTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                LoginTextBox.Text = "Login";
                LoginTextBox.Foreground = Brushes.Gray;
            }
        }


        public void OnPasswordTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text == "Password")
            {
                PasswordTextBox.Text = string.Empty;
                PasswordTextBox.Foreground = Brushes.Black;
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


        public void OnRepeatPasswordTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            if (RepeatPasswordTextBox.Text == "Repeat password")
            {
                RepeatPasswordTextBox.Text = string.Empty;
                RepeatPasswordTextBox.Foreground = Brushes.Black;
                RepeatPasswordTextBox.CaretIndex = 0;
            }
        }


        public void OnRepeatPasswordTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RepeatPasswordTextBox.Text))
            {
                RepeatPasswordTextBox.Text = "Repeat password";
                RepeatPasswordTextBox.Foreground = Brushes.Gray;
            }
        }

    }
}
