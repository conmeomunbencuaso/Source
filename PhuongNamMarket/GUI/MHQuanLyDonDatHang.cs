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
    public partial class MHQuanLyDonDatHang : Form
    {
        public  BUS.DonDatHangBUS DonDatHangBUS { get; set; }

        public MHQuanLyDonDatHang()
        {
            InitializeComponent();
            DonDatHangBUS = new BUS.DonDatHangBUS();
        }

        private void BtnTaoDonDatHang_Click(object sender, EventArgs e)
        {
            MHTaoDonDatHang taoDonDatHang = new MHTaoDonDatHang();
            this.Hide();
            taoDonDatHang.ShowDialog();
        }

        private void MHQuanLyDonDatHang_Load(object sender, EventArgs e)
        {
            dtgvDanhSachDonDatHang.DataSource = DonDatHangBUS.LayDanhSachDonDatHang();
        }

    }
}
