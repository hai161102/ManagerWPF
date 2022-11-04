using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model
{
    public class AccountManager
    {
        public static int NORMAL_PERMISSION = 2;
        public static int ADMIN_PERMISSION = 1;
        private string username;
        private string password;
        private int permission = NORMAL_PERMISSION;

        public AccountManager(string username, string password, int permission)
        {
            this.username = username;
            this.password = password;
            this.permission = permission;
        }

        public AccountManager()
        {
        }

        public void setUserName(string username)
        {
            this.username = username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getUserName()
        {
            return this.username;
        }

        public string getPassword()
        {
            return this.password;
        }

        public int getPermission()
        {
            return this.permission;
        }
    }
}
