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
        public BUS.NhaCungCapBUS NhaCungCapBUS { get; set; }

        public MHQuanLyDonDatHang()
        {
            InitializeComponent();
            InitBusLayer();
        }

        public void InitBusLayer()
        {
            DonDatHangBUS = new BUS.DonDatHangBUS();
            NhaCungCapBUS = new BUS.NhaCungCapBUS();
        }

        private void BtnTaoDonDatHang_Click(object sender, EventArgs e)
        {
            MHTaoDonDatHang taoDonDatHang = new MHTaoDonDatHang();
            this.Hide();
            taoDonDatHang.ShowDialog();
        }

        private void MHQuanLyDonDatHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachDonDatHang();
            HienThiTrangThaiDonDatHang();
            HienThiDanhSachNhaCungCap();
        }

        private void HienThiDanhSachNhaCungCap()
        {
            cbbTimKiemTheoNhaCungCap.DataSource = NhaCungCapBUS.LayDanhSachNhaCungCap();
            cbbTimKiemTheoNhaCungCap.DisplayMember = "TenNhaCungCap";
            cbbTimKiemTheoNhaCungCap.ValueMember = "MaNhaCungCap";

            cbbNhaCungCap.DataSource = NhaCungCapBUS.LayDanhSachNhaCungCap();
            cbbNhaCungCap.DisplayMember = "TenNhaCungCap";
            cbbNhaCungCap.ValueMember = "MaNhaCungCap";
        }

        private void HienThiTrangThaiDonDatHang()
        {
            cbbTimKiemTheoTrangThai.DataSource = DonDatHangBUS.LayDanhSachTrangThaiDonDatHang();
            cbbTimKiemTheoTrangThai.DisplayMember = "TenTrangThai";
            cbbTimKiemTheoTrangThai.ValueMember = "MaTrangThaiDonDatHang";

            cbbTrangThai.DataSource = DonDatHangBUS.LayDanhSachTrangThaiDonDatHang();
            cbbTrangThai.DisplayMember = "TenTrangThai";
            cbbTrangThai.ValueMember = "MaTrangThaiDonDatHang";
        }

        private void HienThiDanhSachDonDatHang()
        {
            dtgvDanhSachDonDatHang.DataSource = DonDatHangBUS.LayDanhSachDonDatHang();
        }

        private void DtgvDanhSachDonDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvDanhSachDonDatHang.DataBindings.Clear();
            txtMaDonDatHang.DataBindings.Clear();
            cbbNhaCungCap.DataBindings.Clear();
            cbbTrangThai.DataBindings.Clear();
            dtpkNgayLap.DataBindings.Clear();

            // Binding data control to control
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
