using ControlzEx.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace LunchIsEasy.UI.Wpf.Model.Data
{
    public static class AccountDBCommand
    {


        public static List<Accounts> GetAllAccounts()
        {
            using (AccountDBContext dataBase = new AccountDBContext())
            {
                var account = dataBase.Accounts.ToList();
                return account;
            }
        }


        public static void RegisterAccount(string name, string surname, string telephone, string login, string password, string repeatpassword)
        {
            if (login == "Login")
            {
                MessageBox.Show("Enter the Login", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (password == "Password")
            {
                MessageBox.Show("Enter the Password", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (password != repeatpassword)
            {
                MessageBox.Show("Invalid password confirmation", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            try
            {
                using (AccountDBContext dataBase = new AccountDBContext())
                {
                    var account = dataBase.Accounts.Any(element => element.Login == login);

                    if (!account)
                    {
                        Accounts newAccounts = new Accounts
                        {
                            Id = 0,
                            Name = name,
                            Surname = surname,
                            Telephone = long.Parse(telephone),
                            Login = login,
                            Password = password,
                            RepeatPassword = repeatpassword

                        };

                        dataBase.Accounts.Add(newAccounts);
                        dataBase.SaveChanges();
                        MessageBox.Show("Registration completed successfully", "Congratulations");

                        Application.Current.MainWindow.Content = new PageAuthorization();
                    }
                    else
                    {
                        MessageBox.Show("User with this login already exists", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



        public static List<Accounts> GetAllLogins()
        {
            using (AccountDBContext dataBase = new AccountDBContext())
            {
                var account = dataBase.Accounts.ToList();
                return account;
            }
        }




    }
}
