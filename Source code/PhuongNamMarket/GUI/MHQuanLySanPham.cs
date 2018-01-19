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
    public partial class MHQuanLySanPham : Form
    {
        public BUS.SanPhamBUS SanPhamBUS { get; set; }
        public BUS.NhaCungCapBUS NhaCungCapBUS { get; set; }

        public MHQuanLySanPham()
        {
            InitializeComponent();
            SanPhamBUS = new BUS.SanPhamBUS();
            NhaCungCapBUS = new BUS.NhaCungCapBUS();
            textBox1.Enabled = false;
        }
        private void LayMa()
        {
            string maSanPham = SanPhamBUS.TaoMaDonDatHang().Rows[0][0].ToString();
            maSanPham = ManHinhChinh.NextID(maSanPham, "SP");
            textBox1.Text = maSanPham;
        }
        private void HienThiDanhSachSanPham()
        {
            dtgvDanhSachSanPham.DataSource = SanPhamBUS.LayDanhSachSanPham();
        }
        private void HienThiDanhSachLoaiSanPham()
        {
            comboBox1.DataSource = SanPhamBUS.LayDanhSachLoaiSanPham();
            comboBox1.DisplayMember = "TenLoaiSanPham";
            comboBox1.ValueMember = "MaLoaiSanPham";
        }
        private void HienThiDanhSachHangSanXuat()
        {
            comboBox3.DataSource = SanPhamBUS.LayDanhSachHangSanXuat();
            comboBox3.DisplayMember = "TenhangSanXuat";
            comboBox3.ValueMember = "MaHangSanXuat";
        }
        
        private void HienThiDanhSachNhaCungCap()
        {
            comboBox2.DataSource = NhaCungCapBUS.LayDanhSachNhaCungCap();
            comboBox2.DisplayMember = "TenNhaCungCap";
            comboBox2.ValueMember = "MaNhaCungCap";
        }
        private void MHQuanLySanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
            HienThiDanhSachNhaCungCap();
            HienThiDanhSachHangSanXuat();
            HienThiDanhSachLoaiSanPham();
            LayMa();
        }

        private void dtgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtgvDanhSachSanPham.DataBindings.Clear();
                textBox1.DataBindings.Clear();
                textBox2.DataBindings.Clear();
                textBox3.DataBindings.Clear();
                numericUpDown1.DataBindings.Clear();
                numericUpDown2.DataBindings.Clear();
                numericUpDown3.DataBindings.Clear();
                numericUpDown4.DataBindings.Clear();
                comboBox2.DataBindings.Clear();
                comboBox1.DataBindings.Clear();
                comboBox3.DataBindings.Clear();
                textBox1.DataBindings.Add(
                   new Binding("Text", dtgvDanhSachSanPham[0, e.RowIndex], "Value", false));
                textBox2.DataBindings.Add(
                   new Binding("Text", dtgvDanhSachSanPham[1, e.RowIndex], "Value", false));
                comboBox2.DataBindings.Add(
                   new Binding("Text", dtgvDanhSachSanPham[7, e.RowIndex], "Value", false));
                textBox3.DataBindings.Add(
                   new Binding("Text", dtgvDanhSachSanPham[4, e.RowIndex], "Value", false));
                comboBox1.DataBindings.Add(
                   new Binding("Text", dtgvDanhSachSanPham[8, e.RowIndex], "Value", false));
                comboBox3.DataBindings.Add(
                   new Binding("Text", dtgvDanhSachSanPham[9, e.RowIndex], "Value", false));

                numericUpDown1.DataBindings.Add(
                   new Binding("Text", dtgvDanhSachSanPham[2, e.RowIndex], "Value", false));
                numericUpDown2.DataBindings.Add(
                   new Binding("Text", dtgvDanhSachSanPham[3, e.RowIndex], "Value", false));
                numericUpDown3.DataBindings.Add(
                   new Binding("Text", dtgvDanhSachSanPham[5, e.RowIndex], "Value", false));
                numericUpDown4.DataBindings.Add(
                   new Binding("Text", dtgvDanhSachSanPham[6, e.RowIndex], "Value", false));
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Vui lòng chọn chính xác đơn đặt hàng !");
            }
        }

        private void btnSuaDDH_Click(object sender, EventArgs e)
        {
            string maSP = textBox1.Text;
            string tenSP = textBox2.Text;
            int giaMua = int.Parse(numericUpDown1.Value.ToString());
            int giaBan = int.Parse(numericUpDown2.Value.ToString());
            string xuatXu = textBox3.Text;
            int thoiGianBaoHanh = int.Parse(numericUpDown3.Value.ToString());
            string hangSX = comboBox3.SelectedValue.ToString();
            string maLoaiSP = comboBox1.SelectedValue.ToString();
            int soLuongTon = int.Parse(numericUpDown4.Value.ToString());
            string maNhaCungCap = comboBox2.SelectedValue.ToString();
            bool a = (bool)SanPhamBUS.ThemSanPham(maSP, tenSP, giaMua, giaBan, xuatXu, thoiGianBaoHanh, hangSX, maLoaiSP, soLuongTon, maNhaCungCap);
            if(a == true)
            {
                MessageBox.Show("Thêm Thành Công");
                HienThiDanhSachSanPham();
                LayMa();
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maSP = textBox1.Text;
            bool a = (bool)SanPhamBUS.XoaSanPham(maSP);
            if (a == true)
            {
                MessageBox.Show("Xóa Thành Công");
                HienThiDanhSachSanPham();
                LayMa();
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maSP = textBox1.Text;
            string tenSP = textBox2.Text;
            int giaMua = int.Parse(numericUpDown1.Value.ToString());
            int giaBan = int.Parse(numericUpDown2.Value.ToString());
            string xuatXu = textBox3.Text;
            int thoiGianBaoHanh = int.Parse(numericUpDown3.Value.ToString());
            string hangSX = comboBox3.SelectedValue.ToString();
            string maLoaiSP = comboBox1.SelectedValue.ToString();
            int soLuongTon = int.Parse(numericUpDown4.Value.ToString());
            string maNhaCungCap = comboBox2.SelectedValue.ToString();
            bool a = (bool)SanPhamBUS.CapNhatSanPham(maSP, tenSP, giaMua, giaBan, xuatXu, thoiGianBaoHanh, hangSX, maLoaiSP, soLuongTon, maNhaCungCap);
            if (a == true)
            {
                MessageBox.Show("Cập Nhật Thành Công");
                HienThiDanhSachSanPham();
            }
            else
            {
                MessageBox.Show("Cập Nhật Thất Bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MHQuanLySanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
