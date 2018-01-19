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
    public partial class MHBanHang : Form
    {

        public BUS.KhachHangBUS KhachHangBUS { get; set; }
        public BUS.SanPhamBUS SanPhamBUS { get; set; }
        public BUS.HoaDonBanHangBUS HoaDonBanHangBUS { get; set; }

        private DataTable dsspDonHang;
        private DataTable dsKhachHang;
        private MHBanHang_SoLuong frmSoLuong;
        private long tongTien = 0;

        public MHBanHang()
        {
            InitializeComponent();
            InitBusLayer();
            InitDanhSachDonHang();
            InitDanhSachKhachHang();
        }

        private void InitDanhSachKhachHang()
        {
            dsKhachHang = (DataTable)KhachHangBUS.LayDanhSachKhachHang();
            cbbMaKH.DataSource = dsKhachHang;
            cbbMaKH.DisplayMember = "MaKhachHang";
            cbbMaKH.ValueMember = "MaKhachHang";
            cbbTenKH.DataSource = dsKhachHang;
            cbbTenKH.DisplayMember = "TenKhachHang";
            cbbTenKH.ValueMember = "MaKhachHang";
            cbbSDT.DataSource = dsKhachHang;
            cbbSDT.DisplayMember = "SoDienThoai";
            cbbSDT.ValueMember = "MaKhachHang";
        }

        private void InitDanhSachDonHang()
        {
            dsspDonHang = new DataTable();
            dsspDonHang.Columns.Add("MaSanPham");
            dsspDonHang.Columns.Add("TenSanPham");
            dsspDonHang.Columns.Add("DonGia", typeof(int));
            dsspDonHang.Columns.Add("SoLuong", typeof(int));
            dsspDonHang.Columns.Add("TongGia", typeof(long));
            dtgvDanhSachSP.DataSource = dsspDonHang;
            tongTien = 0;
            lbTongTien.Text = tongTien.ToString();
        }

        public void InitBusLayer()
        {
            SanPhamBUS = new BUS.SanPhamBUS();
            KhachHangBUS = new BUS.KhachHangBUS();
            HoaDonBanHangBUS = new BUS.HoaDonBanHangBUS();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            MHThemSanPham frmThemSP = new MHThemSanPham();
            frmThemSP.themSPVDH += ThemSanPhamVaoDonHang;
            frmThemSP.Show();
        }

        private void ThemSanPhamVaoDonHang(string maSP, string tenSP, int donGia, int soLuong)
        {

            if (!(bool)SanPhamBUS.CapNhatSoLuongTonGiam(maSP, soLuong.ToString()))
            {
                MessageBox.Show("Cập nhật số lượng tồn thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow spMoi = dsspDonHang.NewRow();
            if (dsspDonHang.Rows.Count > 0)
            {
                DataRow[] productRow = dsspDonHang.Select("MaSanPham = '" + maSP + "'");
                if (productRow.Length > 0)
                {
                    productRow[0]["SoLuong"] = long.Parse(productRow[0]["SoLuong"].ToString()) + soLuong;
                    productRow[0]["TongGia"] = long.Parse(productRow[0]["TongGia"].ToString()) + donGia * soLuong;
                    tongTien = tongTien + donGia * soLuong;
                    lbTongTien.Text = tongTien.ToString();
                }
                else
                {
                    spMoi["MaSanPham"] = maSP;
                    spMoi["TenSanPham"] = tenSP;
                    spMoi["DonGia"] = donGia;
                    spMoi["SoLuong"] = soLuong;
                    spMoi["TongGia"] = donGia * soLuong;
                    tongTien = tongTien + donGia * soLuong;
                    lbTongTien.Text = tongTien.ToString();
                    dsspDonHang.Rows.Add(spMoi);
                }
            }
            else
            {
                spMoi["MaSanPham"] = maSP;
                spMoi["TenSanPham"] = tenSP;
                spMoi["DonGia"] = donGia;
                spMoi["SoLuong"] = soLuong;
                spMoi["TongGia"] = donGia * soLuong;
                tongTien = tongTien + donGia * soLuong;
                lbTongTien.Text = tongTien.ToString();
                dsspDonHang.Rows.Add(spMoi);
            }

        }

        private void dtgvDanhSachSP_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDanhSachSP.SelectedRows.Count > 0)
            {
                btnXoaSP.Enabled = true;
            }
            else
            {
                btnXoaSP.Enabled = false;
            }
        }

        private void dtgvDanhSachSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maSanPham = dtgvDanhSachSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tenSanPham = dtgvDanhSachSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            int soLuongCu = int.Parse(dtgvDanhSachSP.Rows[e.RowIndex].Cells[3].Value.ToString());
            frmSoLuong = new MHBanHang_SoLuong(maSanPham + " - " + tenSanPham, maSanPham, soLuongCu);
            DialogResult rs = frmSoLuong.ShowDialog();
            if (rs == DialogResult.OK)
            {
                int soLuong = frmSoLuong.SoLuong;
                DataRow[] productRow = dsspDonHang.Select("MaSanPham = '" + maSanPham + "'");
                if (productRow.Length > 0)
                {
                    if (!(bool)SanPhamBUS.CapNhatSoLuongTonGiam(maSanPham, (soLuong - soLuongCu).ToString()))
                    {
                        MessageBox.Show("Cập nhật số lượng tồn thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    long donGia = long.Parse(productRow[0]["DonGia"].ToString());
                    productRow[0]["SoLuong"] = soLuong;
                    productRow[0]["TongGia"] = (long)(donGia * soLuong);
                    tongTien = tongTien + (donGia * (soLuong - soLuongCu));
                    lbTongTien.Text = tongTien.ToString();
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan();
            InitDanhSachDonHang();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HuyGiaoDich();
            InitDanhSachDonHang();
        }

        private void ThanhToan()
        {
            if (dsspDonHang.Rows.Count > 0)
            {
                string maHDBH = HoaDonBanHangBUS.LayMaHoaDonBanHangCuoiCung().Rows[0][0].ToString();
                maHDBH = ManHinhChinh.NextID(maHDBH, "HD");

                string ngayLap = DateTime.Now.ToString("yyyy-MM-dd");
                string maKH = cbbMaKH.SelectedValue.ToString();
                string maNV = ManHinhChinh.user;

                if (HoaDonBanHangBUS.TaoHoaDonBanHang(maHDBH, ngayLap, tongTien, 1, maKH, maNV))
                {
                    foreach (DataRow row in dsspDonHang.Rows)
                    {
                        string maSP = row.Field<string>(0);
                        int soLuong = row.Field<int>(3);
                        try {
                            HoaDonBanHangBUS.TaoChiTietHoaDonBanHang(maSP, maHDBH, soLuong.ToString());
                        }
                        catch { }


                    }
                }
            }



        }

        private void HuyGiaoDich()
        {
            foreach (DataRow row in dsspDonHang.Rows)
            {
                string maSP = row.Field<string>(0);
                int soLuong = row.Field<int>(3) * (-1);
                if (!(bool)SanPhamBUS.CapNhatSoLuongTonGiam(maSP, soLuong.ToString()))
                {
                    MessageBox.Show("Cập nhật số lượng tồn thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

        }

        private void MHBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dsspDonHang.Rows.Count > 0)
            {
                var rs = MessageBox.Show("Có mặt hàng trong danh sách chưa thanh toán.\nBạn muốn hủy giao dịch này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    HuyGiaoDich();
                    ManHinhChinh.frmMain.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                ManHinhChinh.frmMain.Show();
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachSP.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvDanhSachSP.SelectedRows)
                {
                    string maSanPham = row.Cells[0].Value.ToString();
                    string tenSanPham = row.Cells[1].Value.ToString();
                    int soLuong = int.Parse(row.Cells[3].Value.ToString()) * (-1);
                    DialogResult rs = MessageBox.Show("Bạn muốn xóa sản phẩm " + maSanPham + " - " + tenSanPham + " khỏi đơn hàng?!", "Xác nhận", MessageBoxButtons.OKCancel);
                    if (rs == DialogResult.OK)
                    {
                        if (!(bool)SanPhamBUS.CapNhatSoLuongTonGiam(maSanPham, soLuong.ToString()))
                        {
                            MessageBox.Show("Cập nhật số lượng tồn thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        DataRow[] productRow = dsspDonHang.Select("MaSanPham = '" + maSanPham + "'");
                        long donGia = long.Parse(productRow[0]["DonGia"].ToString());
                        tongTien = tongTien - donGia * soLuong;
                        lbTongTien.Text = tongTien.ToString();
                        dsspDonHang.Rows.Remove(productRow[0]);

                    }
                }
            }
        }
    }
}
