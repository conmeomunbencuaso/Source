using System;
using System.Collections.Generic;
using System.Data;
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

        public object LayDanhSachSanPham()
        {
            return SanPhamDAO.LayDanhSachSanPham();
        }
        public object LayDanhSachHangSanXuat()
        {
            return SanPhamDAO.LayDanhSachHangSanXuat();
        }
        public object LayDanhSachLoaiSanPham()
        {
            return SanPhamDAO.LayDanhSachLoaiSanPham();
        }
        public object ThemSanPham(string maSP, string tenSP, int giaMua, int giaBan, string xuatXu, int thoiGianBaoHanh, string hangSX, string maLoaiSP, int soLuongTon, string maNhaCungCap)
        {
            return SanPhamDAO.ThemSanPham( maSP, tenSP,  giaMua,  giaBan,  xuatXu,  thoiGianBaoHanh,  hangSX,  maLoaiSP,  soLuongTon,  maNhaCungCap);
        }
        public object XoaSanPham(string maSP)
        {
            return SanPhamDAO.XoaSanPham(maSP);
        }

        public object CapNhatSanPham(string maSP, string tenSP, int giaMua, int giaBan, string xuatXu, int thoiGianBaoHanh, string hangSX, string maLoaiSP, int soLuongTon, string maNhaCungCap)
        {
            return SanPhamDAO.CapNhatSanPham(maSP, tenSP, giaMua, giaBan, xuatXu, thoiGianBaoHanh, hangSX, maLoaiSP, soLuongTon, maNhaCungCap);
        }

        public DataTable TaoMaDonDatHang()
        {
            return SanPhamDAO.LayMaSanPhamCuoiCung();
        }

    }
}
