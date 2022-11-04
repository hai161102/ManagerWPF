using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model
{
    public class ChiNhanh
    {
        private string maChiNhanh;
        private string tenChiNhanh;
        private string diaChi;
        private string hotline;

        public string MaChiNhanh { get => maChiNhanh; set => maChiNhanh = value; }
        public string TenChiNhanh { get => tenChiNhanh; set => tenChiNhanh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Hotline { get => hotline; set => hotline = value; }

        public ChiNhanh(string maChiNhanh, string tenChiNhanh, string diaChi, string hotline)
        {
            this.MaChiNhanh = maChiNhanh;
            this.TenChiNhanh = tenChiNhanh;
            this.DiaChi = diaChi;
            this.Hotline = hotline;
        }

        public ChiNhanh()
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
            return this.MaChiNhanh;
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
