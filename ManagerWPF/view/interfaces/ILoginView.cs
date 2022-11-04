using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.view.interfaces
{
    public interface ILoginView
    {
        void onLoginSuccess(object data);
        void onLoginFailure(string message);
    }
}
