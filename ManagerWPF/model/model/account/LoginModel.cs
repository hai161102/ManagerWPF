using Manager.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model.model.account
{
    public class LoginModel
    {
        private ILoginModel _loginModel;
        private ManagerDao managerDao;

        public LoginModel(ILoginModel loginModel)
        {
            _loginModel = loginModel;
            managerDao = new ManagerDao();
            managerDao.setILoginModel(_loginModel);
        }


        public void login(Object obj)
        {
            managerDao.login(obj);
        }
    }
}
