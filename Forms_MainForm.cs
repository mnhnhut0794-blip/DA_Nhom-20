using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an
{
    internal class Forms_MainForm
    {
        Data_BangBam kho = new Data_BangBam(10);

        public Forms_MainForm()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = int.Parse(txtMaHang.Text);
                string ten = txtTenHang.Text.Trim();

                kho.Chen(new HangHoa(ma, ten));
                HienThi();
                MessageBox.Show("Đã thêm hàng hóa!");
            }
            catch
            {
                MessageBox.Show("Lỗi nhập dữ liệu!");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaHang.Text);
            var hh = kho.TimKiem(ma);
            MessageBox.Show(hh != null ? $"Tìm thấy: {hh}" : "Không tìm thấy!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaHang.Text);
            kho.Xoa(ma);
            HienThi();
            MessageBox.Show("Đã xóa hàng hóa!");
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = kho.LayTatCa();
        }
    }
}
