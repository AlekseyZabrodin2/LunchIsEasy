using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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




    }
}
