using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model
{
    public class Luong
    {
        private int bacLuong;
        private float luongCoBan;
        private float heSoLuong;
        private float phuCap;

        public int BacLuong { get => bacLuong; set => bacLuong = value; }
        public float LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public float PhuCap { get => phuCap; set => phuCap = value; }

        public Luong(int bacLuong, float luongCoBan, float heSoLuong, float phuCap)
        {
            this.BacLuong = bacLuong;
            this.LuongCoBan = luongCoBan;
            this.HeSoLuong = heSoLuong;
            this.PhuCap = phuCap;
        }

        public Luong()
        {
        }

        public override string ToString()
        {
            //return GetType().GetProperties()
            //.Select(info => (info.Name, Value: info.GetValue(this, null) ?? "(null)"))
            //.Aggregate(
            //new StringBuilder(),
            //(sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
            //sb => sb.ToString());
            return this.BacLuong.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
