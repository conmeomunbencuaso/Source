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
        public BUS.DonDatHangBUS DonDatHangBUS { get; set; }

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

        private void DtgvDanhSachDonDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDonDatHang.DataBindings.Add(
                new Binding("Text", dtgvDanhSachDonDatHang[0, e.RowIndex], "Value", false));
            dtpkNgayLap.DataBindings.Add(
               new Binding("Text", dtgvDanhSachDonDatHang[1, e.RowIndex], "Value", false));
            cbbTrangThai.DataBindings.Add(
               new Binding("Text", dtgvDanhSachDonDatHang[2, e.RowIndex], "Value", false));
            cbbNhaCungCap.DataBindings.Add(
               new Binding("Text", dtgvDanhSachDonDatHang[3, e.RowIndex], "Value", false));
        }
    }
}
