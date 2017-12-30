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
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void BtnBanHang_Click(object sender, EventArgs e)
        {
            MHBanHang mHBanHang = new MHBanHang();
            this.Hide();
            mHBanHang.ShowDialog();
        }

        private void BtnQuanLy_Click(object sender, EventArgs e)
        {
            MHQuanLyDonDatHang quanLyDonDatHang = new MHQuanLyDonDatHang();
            this.Hide();
            quanLyDonDatHang.ShowDialog();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
