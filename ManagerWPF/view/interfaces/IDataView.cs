using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.view.interfaces
{
    public interface IDataView
    {
        void onResultSuccess(Object data);
        void onResultError(String message);
    }
}
