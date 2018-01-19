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

    }
}
