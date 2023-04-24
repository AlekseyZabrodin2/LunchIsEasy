﻿using System;
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




        public void OnTelephoneTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            if (TelephoneTextBox.Text == string.Empty)
            {
                TelephoneTextBox.Text = "+375";
                TelephoneTextBox.Foreground = Brushes.Black;
                TelephoneTextBox.CaretIndex = 0;
            }
        }


       
    }
}
