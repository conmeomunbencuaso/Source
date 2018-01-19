using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        public DataProvider Provider { get; set; }

        public SanPhamDAO()
        {
            Provider = new DataProvider();
        }

        public DataTable LayDanhSachSanPhamChoDatHang()
        {
            var query = @"SELECT MaSanPham, TenSanPham, GiaMua, TenNhaCungCap, sp.MaNhaCungCap
                        FROM SanPham sp join NhaCungCap ncc on sp.MaNhaCungCap = ncc.MaNhaCungCap";

            var dsSanPham = Provider.GetTable(query);
            return dsSanPham;
        }

        public DataTable LayDanhSachSanPhamTheoTuKhoa(string tuKhoa)
        {
            var query = @"SELECT MaSanPham, TenSanPham, GiaBan, ThoiGianBaoHanh, SoLuongTon
                          FROM SanPham sp 
                          WHERE MaSanPham LIKE '%" + tuKhoa + "%' or TenSanPham LIKE '%" + tuKhoa + "%'";

            var dsSanPham = Provider.GetTable(query);
            return dsSanPham;
        }

        public string LaySoLuongTonTheoMaSanPham(string maSP)
        {
            var query = @"SELECT SoLuongTon
                        FROM SanPham sp 
                        WHERE MaSanPham = '" + maSP + "'";

            var sltSanPham = Provider.GetTable(query).Rows[0][0].ToString();
            return sltSanPham;
        }

        public bool CapNhatSoLuongTonGiam(string maSP, string soLuongGiam)
        {
            var query = @"UPDATE SanPham SET SoLuongTon = SoLuongTon - (" + soLuongGiam + ") WHERE MaSanPham='" + maSP + "'";

            var cnSLT = Provider.ExecuteUpdateQuery(query);
            return cnSLT;
        }

        public DataTable LayDanhSachSanPham()
        {
            var query = @"SELECT sp.MaSanPham,sp.TenSanPham,SP.GiaMua,SP.GiaBan,SP.XuatXu,Sp.ThoiGianBaoHanh,SP.SoLuongTon,ncc.TenNhaCungCap,lsp.TenLoaiSanPham,HSX.TenhangSanXuat
                        FROM SanPham sp JOIN dbo.NhaCungCap ncc ON ncc.MaNhaCungCap=SP.MaNhaCungCap JOIN dbo.LoaiSanPham lsp ON lsp.MaLoaiSanPham=sp.MaLoaiSanPham JOIN dbo.HangSanXuat HSX ON HSX.MaHangSanXuat=SP.HangSanXuat";

            var dsSanPham = Provider.GetTable(query);
            return dsSanPham;
        }

        public DataTable LayDanhSachHangSanXuat()
        {
            var query = @"SELECT *
                        FROM HangSanXuat ";

            var dsSanPham = Provider.GetTable(query);
            return dsSanPham;
        }

        public DataTable LayDanhSachLoaiSanPham()
        {
            var query = @"SELECT *
                        FROM LoaiSanPham ";

            var dsSanPham = Provider.GetTable(query);
            return dsSanPham;
        }

        public bool ThemSanPham(string maSP, string tenSP,int giaMua,int giaBan,string xuatXu,int thoiGianBaoHanh,string hangSX,string maLoaiSP,int soLuongTon,string maNhaCungCap)
        {
            var query = @"Insert into SanPham (MaSanPham,TenSanPham,GiaMua,GiaBan,XuatXu,ThoiGianBaoHanh,HangSanXuat,MaLoaiSanPham,SoLuongTon,MaNhaCungCap)
                            values("+ "'"+ maSP +"','"+ tenSP + "'," + giaMua + "," + giaBan + ",'" + xuatXu + "'," + thoiGianBaoHanh + ",'" + hangSX + "','" + maLoaiSP + "'," + soLuongTon + ",'" + maNhaCungCap +"'"+")";

            var cnSLT = Provider.ExecuteUpdateQuery(query);
            return cnSLT;
        }
        public bool XoaSanPham(string maSP)
        {
            var query = @"Delete from SanPham where MaSanPham = '"+maSP+"'";

            var cnSLT = Provider.ExecuteUpdateQuery(query);
            return cnSLT;
        }

        public bool CapNhatSanPham(string maSP, string tenSP, int giaMua, int giaBan, string xuatXu, int thoiGianBaoHanh, string hangSX, string maLoaiSP, int soLuongTon, string maNhaCungCap)
        {
            var query = @"Update SanPham 
                        set" + " TenSanPham = '" + tenSP + "',GiaMua = " + giaMua + ",GiaBan = " + giaBan + ",XuatXu= '" + xuatXu + "',ThoiGianBaoHanh= " + thoiGianBaoHanh + ",HangSanXuat='" + hangSX + "',MaLoaiSanPham='" + maLoaiSP + "',SoLuongTon= " + soLuongTon + ",MaNhaCungCap= '" + maNhaCungCap + "'" + 
                        " Where MaSanPham='"+maSP+"'";

            var cnSLT = Provider.ExecuteUpdateQuery(query);
            return cnSLT;
        }
        public DataTable LayMaSanPhamCuoiCung()
        {
            var query = @"SELECT TOP 1 MaSanPham FROM SanPham Order by MaSanPham DESC";

            var maSanPham = Provider.GetTable(query);
            return maSanPham;
        }
    }
}
