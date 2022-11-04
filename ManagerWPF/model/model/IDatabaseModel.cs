using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model.model
{
    public interface IDatabaseModel
    {
        void onSuccess(Object data);
        void onFailure(String message);
    }
}
