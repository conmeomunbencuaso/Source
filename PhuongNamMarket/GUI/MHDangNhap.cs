﻿using System;
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

        public MHDangNhap()
        {
            InitializeComponent();
            InitBackgroud();
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
            if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "123")
            {
                Program.OpenDetailFormOnClose = true;
                this.Close();
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
