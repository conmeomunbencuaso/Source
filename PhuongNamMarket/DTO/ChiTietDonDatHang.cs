using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDonDatHang
    {
        private string maDonDatHang;
        private string maSanPham;
        private int soLuong;

        public ChiTietDonDatHang(string maDonDatHang, string maSanPham, int soLuong)
        {
            this.maDonDatHang = maDonDatHang;
            this.maSanPham = maSanPham;
            this.soLuong = soLuong;
        }

        public string MaDonDatHang { get => maDonDatHang; set => maDonDatHang = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
