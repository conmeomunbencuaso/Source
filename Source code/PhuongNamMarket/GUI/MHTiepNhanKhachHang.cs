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
    public partial class MHTiepNhanKhachHang : Form
    {
        public BUS.KhachHangBUS KhachHangBUS { get; set; }
        
        public MHTiepNhanKhachHang()
        {
            InitializeComponent();
            InitBusLayer();
        }

        public void InitBusLayer()
        {
            KhachHangBUS = new BUS.KhachHangBUS();
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (!txtTenKhachHang.Text.Equals(string.Empty) && !txtSDT.Text.Equals(string.Empty) && !txtDiaChi.Text.Equals(string.Empty))
            {
                string maKH = KhachHangBUS.LayMaKhachHangCuoiCung().Rows[0][0].ToString();
                maKH = ManHinhChinh.NextID(maKH,"KH");
                string tenKH = txtTenKhachHang.Text;
                string sdt = txtSDT.Text;
                string diaChi = txtDiaChi.Text;
                if(KhachHangBUS.ThemKhachHang(maKH, tenKH, sdt, diaChi))
                {
                    MessageBox.Show("Tiếp nhận khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Tiếp nhận khách hàng thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Điền đủ thông tin khách hàng!");
            }
        }

        private void MHTiepNhanKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
