using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekHomework.Accounts
{
    public class Users :Accounts
    {
        public List<Accounts> accountsList { get; set; }
        public Users()
        {
            accountsList = new List<Accounts>();
            accountsList.Add(new Accounts { accountNumber = 1, userName = "Alper Kocasalih", password = "12345", Balance=1000, eMail ="alperkocasalih@gmail.com" });
            accountsList.Add(new Accounts { accountNumber = 2, userName = "user2", password = "password2" , Balance = 100, eMail = "alperkocasalih@gmail.com" });
            accountsList.Add(new Accounts { accountNumber = 3, userName = "user3", password = "password3" , Balance = 1000 , eMail = "alperkocasalih@gmail.com" });
            accountsList.Add(new Accounts { accountNumber = 4, userName = "user4", password = "password4" , Balance = 10000 , eMail = "alperkocasalih@gmail.com" });
            accountsList.Add(new Accounts { accountNumber = 5, userName = "user5", password = "password5" , Balance = 1000 , eMail = "alperkocasalih@gmail.com" });

        }
    }
}
