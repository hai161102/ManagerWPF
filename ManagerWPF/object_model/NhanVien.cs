using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model
{
    public class NhanVien
    {
        private int id;
        private string hoTen;
        private string soDienThoai;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string queQuan;
        private ChiNhanh chiNhanh;
        private ChucVu chucVu;
        private Luong bacLuong;


        public NhanVien()
        {
        }

        public NhanVien(int id, string hoTen, string soDienThoai, DateTime ngaySinh, string gioiTinh, string queQuan, ChiNhanh chiNhanh, ChucVu chucVu, Luong bacLuong)
        {
            this.Id = id;
            this.HoTen = hoTen;
            this.SoDienThoai = soDienThoai;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.QueQuan = queQuan;
            this.ChiNhanh = chiNhanh;
            this.ChucVu = chucVu;
            this.BacLuong = bacLuong;
        }

        public int Id { get => id; set => id = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public ChiNhanh ChiNhanh { get => chiNhanh; set => chiNhanh = value; }
        public ChucVu ChucVu { get => chucVu; set => chucVu = value; }
        public Luong BacLuong { get => bacLuong; set => bacLuong = value; }
    }
}