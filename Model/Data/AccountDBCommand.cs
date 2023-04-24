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

        

        public static bool RegisterAccount(string name, string surname, string telephone, string login, string password, string repeatpassword)
        {
            var registerAccount = false; 

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

                        MessageBox.Show("Registration completed successfully", "Congratulations", MessageBoxButton.OK, MessageBoxImage.Information);
                        return registerAccount = true;
                    }
                    else
                    {
                        MessageBox.Show("User with this login already exists", "Information", MessageBoxButton.OK, MessageBoxImage.Error);                        
                        return registerAccount;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }




        public static bool AccountAuthorization(string login, string password)
        {
            var registerAccount = false;

            try
            {
                using (AccountDBContext dataBase = new AccountDBContext())
                {
                    var account = dataBase.Accounts.Any(element => element.Login == login && element.Password == password);

                    if (account)
                    {
                        MessageBox.Show("Authorization was successful", "Congratulations", MessageBoxButton.OK, MessageBoxImage.Information);
                        return registerAccount = true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong login or password", "Information", MessageBoxButton.OK, MessageBoxImage.Error);
                        return registerAccount;
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
