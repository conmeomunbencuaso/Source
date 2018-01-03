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
    public partial class MHBanHang_SoLuong : Form
    {
        public BUS.SanPhamBUS SanPhamBUS { get; set; }
        public int SoLuong { get; set; }
        private string maSP;
        private int soLuongTonCu;
        public MHBanHang_SoLuong(string nameTitle, string maSP, int soLuongTon)
        {
            InitializeComponent();
            InitBusLayer();
            this.Text = nameTitle;
            this.maSP = maSP;
            nmSoLuong.Value = soLuongTon;
            soLuongTonCu = soLuongTon;
            CapNhatSLT();
            timerCapNhatSLT.Enabled = true;
        }

        public void InitBusLayer()
        {
            SanPhamBUS = new BUS.SanPhamBUS();
        }

        public void CapNhatSLT()
        {
            txtTonKho.Text = (string)SanPhamBUS.LaySoLuongTonTheoMaSanPham(maSP);
            nmSoLuong.Maximum = int.Parse(txtTonKho.Text) + soLuongTonCu;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.SoLuong = (int)nmSoLuong.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.SoLuong = 0;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void timerCapNhatSLT_Tick(object sender, EventArgs e)
        {
            CapNhatSLT();
        }
    }
}
