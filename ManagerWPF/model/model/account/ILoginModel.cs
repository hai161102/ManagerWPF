using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model.model.account
{
    public interface ILoginModel
    {
        void onLoginSuccess(object data);
        void onLoginFailure(string message);
    }
}
