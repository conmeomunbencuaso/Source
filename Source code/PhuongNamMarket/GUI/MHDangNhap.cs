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
    public partial class MHDangNhap : Form
    {
        public BUS.NhanVienBUS NhanVienBUS { get; set; }

        public MHDangNhap()
        {
            InitializeComponent();
            InitBackgroud();
            InitBusLayer();
        }

        public void InitBusLayer()
        {
            NhanVienBUS = new BUS.NhanVienBUS();
        }

        private void InitBackgroud()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {

            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                if(NhanVienBUS.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                {
                    ManHinhChinh.user = txtTaiKhoan.Text;
                    Program.OpenDetailFormOnClose = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nhập tài khoản và mật khẩu!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MHDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
