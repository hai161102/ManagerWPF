using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model.instance
{
    public class UserAccount : AccountManager
    {
        private NhanVien nhanVien;
        public UserAccount()
        {
        }

        public UserAccount(string username, string password, int permission, NhanVien nhanVien) : base(username, password, permission)
        {
            this.nhanVien = nhanVien;
        }

        public NhanVien getNhanVien()
        {
            return nhanVien;
        }

        public void setNhanVien(NhanVien nhan)
        {
            this.nhanVien = nhan;
        }
    }
}
