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

        bool allClose = true;

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
            taoDonDatHang.Show();
            allClose = false;
            this.Close();
        }

        private void MHQuanLyDonDatHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachDonDatHang();
            HienThiTrangThaiDonDatHang();
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
            try
            {
                dtgvDanhSachDonDatHang.DataBindings.Clear();
                txtMaDonDatHang.DataBindings.Clear();
                cbbTrangThai.DataBindings.Clear();
                dtpkNgayLap.DataBindings.Clear();

                // Binding data control to control
                txtMaDonDatHang.DataBindings.Add(
                    new Binding("Text", dtgvDanhSachDonDatHang[0, e.RowIndex], "Value", false));
                dtpkNgayLap.DataBindings.Add(
                   new Binding("Text", dtgvDanhSachDonDatHang[1, e.RowIndex], "Value", false));
                cbbTrangThai.DataBindings.Add(
                   new Binding("Text", dtgvDanhSachDonDatHang[2, e.RowIndex], "Value", false));
             
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Vui lòng chọn chính xác đơn đặt hàng !");
            }

        }

        private void BtnTimKiemDonDatHang_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimKiemTheoMaDonDatHang.Text;
            string searchTT = cbbTimKiemTheoTrangThai.SelectedValue.ToString();
            try
            {
                dtgvDanhSachDonDatHang.DataSource = DonDatHangBUS.TimKiemDonDatHang(searchValue, searchTT);
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Không tìm thấy đơn đặt hàng!");
            }
        }

        private void btnXemToanBo_Click(object sender, EventArgs e)
        {
            dtgvDanhSachDonDatHang.DataSource = DonDatHangBUS.LayDanhSachDonDatHang();
        }

        private void btnSuaDDH_Click(object sender, EventArgs e)
        {
            string updateID = txtMaDonDatHang.Text;
            if (updateID == "")
                return;
            string updateNL = dtpkNgayLap.Value.Date.ToString("yyyy-MM-dd");
            string updateTT = cbbTrangThai.SelectedValue.ToString();
            if ((bool)DonDatHangBUS.SuaDonDatHang(updateID, updateNL, updateTT))
                MessageBox.Show("Sửa thành công đơn đặt hàng " + updateID + "!");
            else MessageBox.Show("Sửa thất bại đơn đặt hàng " + updateID + "!");
        }

        private void BtnXoaDDH_Click(object sender, EventArgs e)
        {
            string maDonDatHang = txtMaDonDatHang.Text;
            if (maDonDatHang == "")
                return;
            DialogResult rs = MessageBox.Show("Bạn muốn xóa đơn đặt hàng " + maDonDatHang + "?!", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                if ((bool)DonDatHangBUS.XoaDonDatHang(maDonDatHang))
                {
                    MessageBox.Show("Xóa thành công đơn đặt hàng " + maDonDatHang + "!");
                    if (dtgvDanhSachDonDatHang.SelectedRows.Count > 0)
                    {
                        foreach (DataGridViewRow item in dtgvDanhSachDonDatHang.SelectedRows)
                        {
                            dtgvDanhSachDonDatHang.Rows.RemoveAt(item.Index);
                        }
                    }
                }
                else MessageBox.Show("Xóa thất bại đơn đặt hàng " + maDonDatHang + "!");
            }
        }

        private void MHQuanLyDonDatHang_Shown(object sender, EventArgs e)
        {
            dtgvDanhSachDonDatHang.DataSource = DonDatHangBUS.LayDanhSachDonDatHang();
        }

        private void MHQuanLyDonDatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(allClose)
                ManHinhChinh.frmMain.Show();
        }

        private void dtgvDanhSachDonDatHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int indexColumn = 2;
            if (e.RowIndex < 0 || e.ColumnIndex != indexColumn)
                return;
            DataGridViewCell cell = dtgvDanhSachDonDatHang.Rows[e.RowIndex].Cells[indexColumn];
            string value = cell.Value == null ? string.Empty : cell.Value.ToString();
            if(value.Equals("Chưa xác nhận"))
            {
                dtgvDanhSachDonDatHang.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Bisque;
            }
            else if (value.Equals("Đã xác nhận"))
            {
                dtgvDanhSachDonDatHang.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Honeydew;
            }
            else if (value.Equals("Đã thanh toán"))
            {
                dtgvDanhSachDonDatHang.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Lavender;
            }
        }
    }
}
