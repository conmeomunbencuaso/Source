using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    public partial class MHTaoDonDatHang : Form
    {
        public BUS.SanPhamBUS SanPhamBUS { get; set; }
        public BUS.NhaCungCapBUS NhaCungCapBUS { get; set; }

        // -------------------------------//
        public BUS.DonDatHangBUS DonDatHangBUS { get; set; }
        public BUS.ChiTietDonDatHangBUS ChiTietDonDatHangBUS { get; set; }
        MHTaoDonDatHang_SoLuong frmSoLuong;
        private long tongTienDonDatHang = 0;
        private int soLuongSanPhamToiThieu = 0;

        private DataTable dsSanPham;
        private DataTable danhSachSanPhamDatHang;


        bool allClose = true;
        public MHTaoDonDatHang()
        {
            InitializeComponent();
            InitBusLayer();
            InitDSSPDH();
        }

        public void InitBusLayer()
        {
            SanPhamBUS = new BUS.SanPhamBUS();
            DonDatHangBUS = new BUS.DonDatHangBUS();
            ChiTietDonDatHangBUS = new BUS.ChiTietDonDatHangBUS();
            NhaCungCapBUS = new BUS.NhaCungCapBUS();
        }

        public void InitDSSPDH()
        {
            danhSachSanPhamDatHang = new DataTable();
            danhSachSanPhamDatHang.Columns.Add("MaSanPhamDat");
            danhSachSanPhamDatHang.Columns.Add("TenSanPhamDat");
            danhSachSanPhamDatHang.Columns.Add("SoLuong", typeof(int));
            danhSachSanPhamDatHang.Columns.Add("TongTien", typeof(long));
            danhSachSanPhamDatHang.Columns.Add("MaNhaCungCapDat");
        }

        private void BtnQuanLyDonDatHang_Click(object sender, EventArgs e)
        {
            MHQuanLyDonDatHang quanLyDonDatHang = new MHQuanLyDonDatHang();
            quanLyDonDatHang.Show();
            allClose = false;
            this.Close();
        }

        private void MHTaoDonDatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (allClose)
                ManHinhChinh.frmMain.Show();
        }

        private void MHTaoDonDatHang_Shown(object sender, EventArgs e)
        {
            InitDSSPDH();
        }
//---------------------------Thủy------------------------------------------

        private void MHTaoDonDatHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhaCungCungCap();
        }

        private void HienThiDanhSachNhaCungCungCap()
        {
            var danhSachNhaCungCap = NhaCungCapBUS.LayDanhSachNhaCungCap();
            cbbDanhSachNhaCungCap.DataSource = danhSachNhaCungCap;
            cbbDanhSachNhaCungCap.DisplayMember = "TenNhaCungCap";
            cbbDanhSachNhaCungCap.ValueMember = "MaNhaCungCap";
        }

        // người dùng chọn nhà cung cấp
        private void CbbDanhSachNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiSanPhamTheoNhaCungCap();
        }

        private void HienThiSanPhamTheoNhaCungCap()
        {
            var maNhaCungCap = cbbDanhSachNhaCungCap.SelectedValue.ToString();
            dsSanPham = (DataTable)NhaCungCapBUS.LayDanhSachSanPhamTheoNhaCungCap(maNhaCungCap);
            dtgvSanPhamTheoNhaCungCap.DataSource = dsSanPham;
            dtgvSanPhamDat.DataSource = danhSachSanPhamDatHang;
        }

        private void BtnChonSanPhamMuonDatHang_Click(object sender, EventArgs e)
        {
            if (dtgvSanPhamTheoNhaCungCap.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvSanPhamTheoNhaCungCap.SelectedRows)
                {
                    string maSanPham = row.Cells[0].Value.ToString();
                    string tenSanPham = row.Cells[1].Value.ToString();
                    frmSoLuong = new MHTaoDonDatHang_SoLuong(maSanPham + " - " + tenSanPham);
                    DialogResult rs = frmSoLuong.ShowDialog();
                    if (rs == DialogResult.OK)
                    {
                        int soLuongSanPham = frmSoLuong.SoLuong;
                        if (DonDatHangBUS.KTSoLuongToiThieuCuaMotSanPham(soLuongSanPham) == true)
                        {
                            HienThiDanhSachSanPhamMuonDatHang(row, maSanPham, tenSanPham, soLuongSanPham);
                        }
                        else
                        {
                            MessageBox.Show("số lượng sản phẩm đặt phải lớn hơn 0!");
                        }
                    }
                }
            }
        }
        private void HienThiDanhSachSanPhamMuonDatHang(DataGridViewRow row, string maSanPham, string tenSanPham, int soLuong)
        {
            long tongTien = Convert.ToInt64(row.Cells[2].Value.ToString()) * soLuong;
            string nhaCungCap = row.Cells[4].Value.ToString();
            if (danhSachSanPhamDatHang.Rows.Count > 0)
            {
                DataRow[] productRow = danhSachSanPhamDatHang.Select("MaSanPhamDat = '" + maSanPham + "'");
                if (productRow.Length > 0)
                {
                    productRow[0]["SoLuong"] = long.Parse(productRow[0]["SoLuong"].ToString()) + soLuong;
                    productRow[0]["TongTien"] = long.Parse(productRow[0]["TongTien"].ToString()) + tongTien;
                    tongTienDonDatHang += tongTien;
                }
                else
                {
                    DataRow newProduct = danhSachSanPhamDatHang.NewRow();
                    newProduct["MaSanPhamDat"] = maSanPham;
                    newProduct["TenSanPhamDat"] = tenSanPham;
                    newProduct["SoLuong"] = soLuong;
                    newProduct["TongTien"] = tongTien;
                    newProduct["MaNhaCungCapDat"] = nhaCungCap;
                    danhSachSanPhamDatHang.Rows.Add(newProduct);
                }
            }
            else
            {
                DataRow newProduct = danhSachSanPhamDatHang.NewRow();
                newProduct["MaSanPhamDat"] = maSanPham;
                newProduct["TenSanPhamDat"] = tenSanPham;
                newProduct["SoLuong"] = soLuong;
                newProduct["TongTien"] = tongTien;
                newProduct["MaNhaCungCapDat"] = nhaCungCap;
                danhSachSanPhamDatHang.Rows.Add(newProduct);
            }
        }

        private void BtnTaoDonDatHang_Click(object sender, EventArgs e)
        {
            tongTienDonDatHang = 0;
            soLuongSanPhamToiThieu = 0;
            foreach (DataGridViewRow row in dtgvSanPhamDat.Rows)
            {
                tongTienDonDatHang += long.Parse(row.Cells[3].Value.ToString());
                soLuongSanPhamToiThieu += 1;
            }
            // kiểm tra ràng buộc
            if (DonDatHangBUS.KiemTraTongTienToiDaCuaDDH(tongTienDonDatHang) == true && DonDatHangBUS.KiemTraSLSPToithieuCuaDDH(soLuongSanPhamToiThieu) == true)
            {
                string maNhaCungCap = cbbDanhSachNhaCungCap.SelectedValue.ToString();
                // tạo mã đơn đặt hàng
                string maDonDatHang = DonDatHangBUS.TaoMaDonDatHang().Rows[0][0].ToString();
                maDonDatHang = ManHinhChinh.NextID(maDonDatHang, "DDH");

                // tạo đơn đặt hàng
                var kiemTraTaoDonDatHang = true;
                if (DonDatHangBUS.TaoDonDatHang(maDonDatHang, DateTime.Now.ToString("yyyy-MM-dd"), "0",tongTienDonDatHang) == true)
                {
                    foreach (DataRow row in danhSachSanPhamDatHang.Rows)
                    {
                        var maSanPham = row.Field<string>(0);
                        var soLuongSanPham = row.Field<int>(2);
                        ChiTietDonDatHang chiTietDonDatHang = new ChiTietDonDatHang(maDonDatHang, maSanPham, soLuongSanPham);
                        if (ChiTietDonDatHangBUS.TaoChiTietDonDatHang(chiTietDonDatHang.MaDonDatHang, chiTietDonDatHang.MaSanPham, chiTietDonDatHang.SoLuong.ToString()) == false)
                        {
                            DonDatHangBUS.XoaDonDatHang(maDonDatHang);
                            kiemTraTaoDonDatHang = false;
                            break;
                        }
                    }
                }
                else
                {
                    kiemTraTaoDonDatHang = false;
                }

                if (kiemTraTaoDonDatHang == true)
                {
                    MessageBox.Show("Tạo đơn đặt hàng thành công !");
                }
                else
                {
                    MessageBox.Show("Tạo đơn đặt hàng thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Tạo đơn hàng thất bại, sai quy định!");
            }
        }

        private void BtnBoChon_Click(object sender, EventArgs e)
        {
            if (dtgvSanPhamDat.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvSanPhamDat.SelectedRows)
                {
                    string maSanPham = row.Cells[0].Value.ToString();
                    string tenSanPham = row.Cells[1].Value.ToString();
                    DialogResult rs = MessageBox.Show("Bạn muốn xóa sản phẩm " + maSanPham + " - " + tenSanPham + " khỏi đơn đặt hàng?!", "Xác nhận", MessageBoxButtons.OKCancel);
                    if (rs == DialogResult.OK)
                    {
                        DataRow[] productRow = danhSachSanPhamDatHang.Select("MaSanPhamDat = '" + maSanPham + "'");
                        danhSachSanPhamDatHang.Rows.Remove(productRow[0]);
                    }
                }
            }
        }
    }
}
