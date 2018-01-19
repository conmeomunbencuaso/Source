using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MHThemSanPham : Form
    {
        public BUS.SanPhamBUS SanPhamBUS { get; set; }

        private DataTable dsSanPham;
        private int index = 0;

        public delegate void ThemSanPhamVaoDonHang(string maSP, string tenSP, int donGia, int soLuong);
        public event ThemSanPhamVaoDonHang themSPVDH;

        public MHThemSanPham()
        {
            InitializeComponent();
            InitBusLayer();
        }

        public void InitBusLayer()
        {
            SanPhamBUS = new BUS.SanPhamBUS();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                index = 0;
                dsSanPham = (DataTable)SanPhamBUS.LayDanhSachSanPhamTheoTuKhoa(txtTuKhoa.Text);

                if (dsSanPham != null)
                {
                    HienThiThongTinSP();
                }

                if (timerCapNhatSLT.Enabled == false)
                    timerCapNhatSLT.Enabled = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSPKe_Click(object sender, EventArgs e)
        {
            if (dsSanPham != null)
            {
                index++;
                if (index >= dsSanPham.Rows.Count)
                    index--;

                HienThiThongTinSP();
            }
        }

        private void btnSPTruoc_Click(object sender, EventArgs e)
        {
            if (dsSanPham != null)
            {
                index--;
                if (index < 0)
                    index = 0;

                HienThiThongTinSP();
            }
        }

        private void HienThiThongTinSP()
        {
            txtTrungKhop.Text = (index + 1) + "/" + dsSanPham.Rows.Count.ToString();
            txtMaSP.Text = dsSanPham.Rows[index]["MaSanPham"].ToString();
            txtTenSP.Text = dsSanPham.Rows[index]["TenSanPham"].ToString();
            txtTonKho.Text = dsSanPham.Rows[index]["SoLuongTon"].ToString();
            txtGiaGoc.Text = dsSanPham.Rows[index]["GiaBan"].ToString();
            txtGiaGiam.Text = dsSanPham.Rows[index]["GiaBan"].ToString();
            txtBaoHanh.Text = dsSanPham.Rows[index]["ThoiGianBaoHanh"].ToString();
        }

        private void btnThemVaoDonHang_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Chưa chọn sản phảm cần mua!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuKhoa.Focus();
                return;
            }

            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Nhập số lượng sản phẩm cần mua!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            int slTon = int.Parse(txtTonKho.Text);
            int slHoaDon = int.Parse(txtSoLuong.Text);


            if (slHoaDon <= slTon)
            {
                themSPVDH(txtMaSP.Text, txtTenSP.Text, int.Parse(txtGiaGiam.Text), int.Parse(txtSoLuong.Text));
            }
            else
            {
                MessageBox.Show("Không đủ số lượng sản phẩm muốn mua!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timerCapNhatSLT_Tick(object sender, EventArgs e)
        {
            txtTonKho.Text = (string)SanPhamBUS.LaySoLuongTonTheoMaSanPham(txtMaSP.Text);
            txtSoLuong.Maximum = int.Parse(txtTonKho.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
