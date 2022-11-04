using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model.model
{
    public class ChamCong
    {
        private float soNgayCong;
        private int maNhanVien;

        public float SoNgayCong { get => soNgayCong; set => soNgayCong = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }

        public ChamCong(float soNgayCong, int maNhanVien)
        {
            this.SoNgayCong = soNgayCong;
            this.MaNhanVien = maNhanVien;
        }

        public ChamCong()
        {
        }

    }
}
