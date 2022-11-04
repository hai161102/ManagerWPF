using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.interfaces
{
    public interface OnViewControlListener
    {
        void onAgree(object[] datas);
        void onCancel();
    }
}
