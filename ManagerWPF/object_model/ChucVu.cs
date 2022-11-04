using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model
{
    public class ChucVu
    {
        private string maChucVu;
        private string chucVuName;

        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string ChucVuName { get => chucVuName; set => chucVuName = value; }

        public ChucVu(string maChucVu, string chucVuName)
        {
            this.MaChucVu = maChucVu;
            this.ChucVuName = chucVuName;
        }

        public ChucVu()
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
            return this.MaChucVu;
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
