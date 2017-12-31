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
        public BUS.DonDatHangBUS DonDatHangBUS { get; set; }
        public BUS.ChiTietDonDatHangBUS ChiTietDonDatHangBUS { get; set; }

        MHQuanLyDonDatHang parent;
        MHTaoDonDatHang_SoLuong frmSoLuong;
        private DataTable dsSanPham;
        private DataTable dsspDatHang;

        public MHTaoDonDatHang(MHQuanLyDonDatHang parent)
        {
            InitializeComponent();
            this.parent = parent;
            InitBusLayer();
            InitDSSPDH();
        }

        public void InitBusLayer()
        {
            SanPhamBUS = new BUS.SanPhamBUS();
            DonDatHangBUS = new BUS.DonDatHangBUS();
            ChiTietDonDatHangBUS = new BUS.ChiTietDonDatHangBUS();
        }

        public void InitDSSPDH()
        {
            dsspDatHang = new DataTable();
            dsspDatHang.Columns.Add("MaSanPhamDat");
            dsspDatHang.Columns.Add("TenSanPhamDat");
            dsspDatHang.Columns.Add("SoLuong", typeof(int));
            dsspDatHang.Columns.Add("TongTien", typeof(long));
            dsspDatHang.Columns.Add("MaNhaCungCapDat");
        }

        private void BtnQuanLyDonDatHang_Click(object sender, EventArgs e)
        {
            MHQuanLyDonDatHang quanLyDonDatHang = new MHQuanLyDonDatHang();
            this.Hide();
            quanLyDonDatHang.ShowDialog();
        }

        private void MHTaoDonDatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        private void MHTaoDonDatHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPhamChoDatHang();
        }

        private void HienThiDanhSachSanPhamChoDatHang()
        {
            dsSanPham = (DataTable)SanPhamBUS.LayDanhSachSanPhamChoDatHang();
            dtgvSanPham.DataSource = dsSanPham;
            dtgvSanPhamDat.DataSource = dsspDatHang;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dtgvSanPham.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvSanPham.SelectedRows)
                {
                    string maSanPham = row.Cells[0].Value.ToString();
                    string tenSanPham = row.Cells[1].Value.ToString();
                    frmSoLuong = new MHTaoDonDatHang_SoLuong(maSanPham + " - " + tenSanPham);
                    DialogResult rs = frmSoLuong.ShowDialog();
                    if (rs == DialogResult.OK)
                    {
                        int soLuong = frmSoLuong.SoLuong;
                        long tongTien = Convert.ToInt64(row.Cells[2].Value.ToString()) * soLuong;
                        string nhaCungCap = row.Cells[4].Value.ToString();
                        if (dsspDatHang.Rows.Count > 0)
                        {
                            DataRow[] productRow = dsspDatHang.Select("MaSanPhamDat = '" + maSanPham + "'");
                            if (productRow.Length > 0)
                            {
                                productRow[0]["SoLuong"] = long.Parse(productRow[0]["SoLuong"].ToString()) + soLuong;
                                productRow[0]["TongTien"] = long.Parse(productRow[0]["TongTien"].ToString()) + tongTien;
                            }
                            else
                            {
                                DataRow newProduct = dsspDatHang.NewRow();
                                newProduct["MaSanPhamDat"] = maSanPham;
                                newProduct["TenSanPhamDat"] = tenSanPham;
                                newProduct["SoLuong"] = soLuong;
                                newProduct["TongTien"] = tongTien;
                                newProduct["MaNhaCungCapDat"] = nhaCungCap;
                                dsspDatHang.Rows.Add(newProduct);
                            }
                        }
                        else
                        {
                            DataRow newProduct = dsspDatHang.NewRow();
                            newProduct["MaSanPhamDat"] = maSanPham;
                            newProduct["TenSanPhamDat"] = tenSanPham;
                            newProduct["SoLuong"] = soLuong;
                            newProduct["TongTien"] = tongTien;
                            newProduct["MaNhaCungCapDat"] = nhaCungCap;
                            dsspDatHang.Rows.Add(newProduct);
                        }
                    }
                }
            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
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
                        DataRow[] productRow = dsspDatHang.Select("MaSanPhamDat = '" + maSanPham + "'");
                        dsspDatHang.Rows.Remove(productRow[0]);
                    }
                }
            }
        }

        private void btnTaoDonDatHang_Click(object sender, EventArgs e)
        {
            List<ChiTietDonDatHang> listCTDDH = new List<ChiTietDonDatHang>();
            Dictionary<string, DonDatHang> listDDH = new Dictionary<string, DonDatHang>();
            bool err = false;
            foreach (DataRow row in dsspDatHang.Rows)
            {
                string maNCC = row.Field<string>(4);

                if (!listDDH.ContainsKey(maNCC))
                {
                    string lastID = DonDatHangBUS.LayMaDonDatHangCuoi().Rows[0][0].ToString(); ;
                    lastID = ManHinhChinh.NextID(lastID, "DDH");
                    if ((bool)DonDatHangBUS.TaoDonDatHang(lastID, DateTime.Now.ToString("yyyy-MM-dd"), maNCC, "0"))
                    {
                        ChiTietDonDatHang ctddh = new ChiTietDonDatHang(lastID, row.Field<string>(0), row.Field<int>(2));
                        DonDatHang ddh = new DonDatHang(lastID, DateTime.Now.ToString("yyyy-MM-dd"), 0, maNCC);
                        listCTDDH.Add(ctddh);
                        listDDH.Add(maNCC, ddh);
                        if (!(bool)ChiTietDonDatHangBUS.TaoChiTietDonDatHang(ctddh.MaDonDatHang, ctddh.MaSanPham, ctddh.SoLuong.ToString()))
                        {
                            err = true;
                        }
                    }
                }
                else
                {
                    string maDDH = listDDH[maNCC].MaDonDatHang;
                    ChiTietDonDatHang ctddh = new ChiTietDonDatHang(maDDH, row.Field<string>(0), row.Field<int>(2));
                    listCTDDH.Add(ctddh);
                    if (!(bool)ChiTietDonDatHangBUS.TaoChiTietDonDatHang(ctddh.MaDonDatHang, ctddh.MaSanPham, ctddh.SoLuong.ToString()))
                    {
                        err = true;
                    }
                }
            }

            if (!err)
            {
                string log = "";
                foreach (KeyValuePair<string, DonDatHang> kv in listDDH)
                {
                    log += "\n  >" + kv.Value.MaDonDatHang + ", " + kv.Value.NgayLap + ": ";
                    foreach (ChiTietDonDatHang ct in listCTDDH)
                    {
                        if (ct.MaDonDatHang == kv.Value.MaDonDatHang)
                        {
                            log += "\n   +" + ct.MaSanPham + " - " + ct.SoLuong;
                        }
                    }
                }
                MessageBox.Show("Tạo thành công các đơn đặt hàng: " + log);
            }
            else
            {
                MessageBox.Show("Vài thông tin tạo lỗi.");
            }
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            dsSanPham.DefaultView.RowFilter = "MaSanPham LIKE '%" + txtProductID.Text + "%'";
        }
    }
}
