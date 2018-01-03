using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class SanPhamBUS
    {
        public DAO.SanPhamDAO SanPhamDAO { get; set; }

        public SanPhamBUS()
        {
            this.SanPhamDAO = new SanPhamDAO();
        }

        public object LayDanhSachSanPhamChoDatHang()
        {
            return SanPhamDAO.LayDanhSachSanPhamChoDatHang();
        }

        public object LayDanhSachSanPhamTheoTuKhoa(string tuKhoa)
        {
            return SanPhamDAO.LayDanhSachSanPhamTheoTuKhoa(tuKhoa);
        }

        public object LaySoLuongTonTheoMaSanPham(string maSP)
        {
            return SanPhamDAO.LaySoLuongTonTheoMaSanPham(maSP);
        }

        public object CapNhatSoLuongTonGiam(string maSP, string soLuongGiam)
        {
            return SanPhamDAO.CapNhatSoLuongTonGiam(maSP, soLuongGiam);
        }
    }
}
