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
    public partial class MHTaoDonDatHang_SoLuong : Form
    {
        public int SoLuong { get; set; }

        public MHTaoDonDatHang_SoLuong(string nameTitle)
        {
            InitializeComponent();
            this.Text = nameTitle;
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
    }
}
