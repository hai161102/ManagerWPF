using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.interfaces
{
    public interface LoginListener
    {
        void loginSuccess();
        void gotoSignUp();
    }
}
