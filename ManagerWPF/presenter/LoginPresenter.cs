using Manager.model;
using Manager.model.model.account;
using Manager.view.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.presenter
{
    public class LoginPresenter : ILoginModel
    {
        private ILoginView loginView;
        private LoginModel loginModel;

        public LoginPresenter(ILoginView loginView)
        {
            this.loginView = loginView;
            loginModel = new LoginModel(this);
        }

        public void onLoginFailure(string message)
        {
            loginView.onLoginFailure(message);
        }

        public void onLoginSuccess(object data)
        {
            loginView.onLoginSuccess(data);
        }

        public void login(AccountManager account)
        {
            loginModel.login(account);
        }
    }
}
