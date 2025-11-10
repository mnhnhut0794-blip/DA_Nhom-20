using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an
{
    internal class Data_BangBam
    {
        private int kichThuoc;
        private List<Models_HangHoa>[] bang;

        public Data_BangBam(int size)
        {
            kichThuoc = size;
            bang = new List<Models_HangHoa>[kichThuoc];
            for (int i = 0; i < kichThuoc; i++)
                bang[i] = new List<Models_HangHoa>();
        }

        private int HamBam(int key) => key % kichThuoc;

        public void Chen(Models_HangHoa hh)
        {
            int index = HamBam(hh.MaHang);
            bang[index].Add(hh);
        }

        public Models_HangHoa TimKiem(int ma)
        {
            int index = HamBam(ma);
            foreach (var hh in bang[index])
                if (hh.MaHang == ma)
                    return hh;
            return null;
        }

        public void Xoa(int ma)
        {
            int index = HamBam(ma);
            bang[index].RemoveAll(x => x.MaHang == ma);
        }

        public List<Models_HangHoa> LayTatCa()
        {
            List<Models_HangHoa> list = new List<Models_HangHoa>();
            foreach (var bucket in bang)
                list.AddRange(bucket);
            return list;
        }
    }
}
