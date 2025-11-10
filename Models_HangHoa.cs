using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an
{
    internal class Models_HangHoa
    {
        public int MaHang { get; set; }
        public string TenHang { get; set; }

        public Models_HangHoa(int ma, string ten)
        {
            MaHang = ma;
            TenHang = ten;
        }

        public override string ToString()
        {
            return $"{MaHang} - {TenHang}";
        } 
    }
}
