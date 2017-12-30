using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DonDatHangDAO
    {
        public DataProvider Provider { get; set; }

        public DonDatHangDAO()
        {
            Provider = new DataProvider();
        }

        public void TaoDonDatHang()
        {

        }
        
        public DataTable LayDanhSachDonDatHang()
        {
            var query = @"SELECT MaDonDatHang,NgayLap,TenTrangThai,TenNhaCungCap FROM DonDatHang DDH 
                        JOIN TrangThaiDonDatHang TTDDH ON DDH.MaTrangTrangThai = TTDDH.MaTrangThaiDonDatHang
                        JOIN NhaCungCap NCC ON DDH.MaNhaCungCap = NCC.MaNhaCungCap";

            var dsDonDatHang = Provider.GetTable(query);
            return dsDonDatHang;
        }

        public DataTable TimKiemDonDatHang(string maDDH, string maNNC, string maTT)
        {
            var query = @"SELECT MaDonDatHang,NgayLap,TenTrangThai,TenNhaCungCap FROM DonDatHang DDH 
                        JOIN TrangThaiDonDatHang TTDDH ON DDH.MaTrangTrangThai = TTDDH.MaTrangThaiDonDatHang
                        JOIN NhaCungCap NCC ON DDH.MaNhaCungCap = NCC.MaNhaCungCap
                        WHERE DDH.MaDonDatHang LIKE '%" + maDDH + "%' and DDH.MaNhaCungCap = '" + maNNC + "' and DDH.MaTrangTrangThai = " + maTT;

            var tkDonDatHang = Provider.GetTable(query);
            return tkDonDatHang;
        }

        public bool SuaDonDatHang(string maDDH, string ngayLap, string maNNC, string maTT)
        {
            var query = @"UPDATE DonDatHang 
            SET MaNhaCungCap = '" + maNNC + "', MaTrangTrangThai = " + maTT + ", NgayLap = '" + ngayLap + "' WHERE MaDonDatHang = '" + maDDH + "'";

            var suaDonDatHang = Provider.ExecuteUpdateQuery(query);
            return suaDonDatHang;
        }

        public bool XoaDonDatHang(string maDDH)
        {
            var query = @"DELETE DonDatHang WHERE MaDonDatHang = '" + maDDH + "'";

            var xoaDonDatHang = Provider.ExecuteUpdateQuery(query);
            return xoaDonDatHang;
        }

        public DataTable LayDanhSachTrangThaiDonDatHang()
        {
            return Provider.GetDataTable("TrangThaiDonDatHang");
        }
    }
}
