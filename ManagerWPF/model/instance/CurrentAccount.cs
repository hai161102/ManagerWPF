using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model.instance
{
    public class CurrentAccount
    {
        private static CurrentAccount instance;
        private UserAccount userAccount;

        private CurrentAccount()
        {
        }

        public static CurrentAccount getInstance()
        {
            if (instance == null)
            {
                instance = new CurrentAccount();
            }
            return instance;
        }

        public void setAccount(UserAccount account)
        {
            this.userAccount = account;
        }

        public UserAccount getAccount()
        {
            return userAccount;
        }
    }
}
