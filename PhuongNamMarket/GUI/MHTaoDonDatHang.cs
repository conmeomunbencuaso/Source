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
    public partial class MHTaoDonDatHang : Form
    {
        MHQuanLyDonDatHang parent;

        public MHTaoDonDatHang(MHQuanLyDonDatHang parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void BtnQuanLyDonDatHang_Click(object sender, EventArgs e)
        {
            MHQuanLyDonDatHang quanLyDonDatHang = new MHQuanLyDonDatHang();
            this.Hide();
            quanLyDonDatHang.ShowDialog();
        }

        private void btnTimKiemSanPham_Click(object sender, EventArgs e)
        {

        }

        private void MHTaoDonDatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }
    }
}
