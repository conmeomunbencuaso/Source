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

        public DataTable LayDanhSachDonDatHang()
        {
            var query = @"SELECT ddh.MaDonDatHang,NgayLap,ttddh.TenTrangThai
                        FROM DonDatHang ddh 
                        JOIN TrangThaiDonDatHang ttddh on ddh.MaTrangThai = ttddh.MaTrangThaiDonDatHang";
            var dsDonDatHang = Provider.GetTable(query);
            return dsDonDatHang;
        }

        public DataTable LayMaDonDatHangCuoiCung()
        {
            var query = @"SELECT TOP 1 MaDonDatHang FROM DonDatHang Order by MaDonDatHang DESC";

            var maDonDatHang = Provider.GetTable(query);
            return maDonDatHang;
        }

        public DataTable TimKiemDonDatHang(string maDDH, string maTT)
        {
            var query = @"SELECT MaDonDatHang,NgayLap, TenTrangThai 
                        FROM DonDatHang DDH JOIN TrangThaiDonDatHang TTDDH ON DDH.MaTrangThai = TTDDH.MaTrangThaiDonDatHang
                        WHERE DDH.MaDonDatHang LIKE '%" + maDDH + "%' and DDH.MaTrangThai = " + maTT;

            var tkDonDatHang = Provider.GetTable(query);
            return tkDonDatHang;
        }

        public bool TaoDonDatHang(string maDDH, string ngayLap, string maTT, long tongTien)
        {
            var query = @"INSERT INTO DonDatHang(MaDonDatHang, NgayLap, MaTrangThai,TongTien)
                        VALUES('" + maDDH + "', '" + ngayLap + "', " + maTT + "," + tongTien + ")";

            var taoDonDatHang = Provider.ExecuteUpdateQuery(query);
            return taoDonDatHang;
        }

        public bool SuaDonDatHang(string maDDH, string ngayLap, string maTT)
        {
            var query = @"UPDATE DonDatHang 
            SET MaTrangTrangThai = " + maTT + ", NgayLap = '" + ngayLap + "' WHERE MaDonDatHang = '" + maDDH + "'";

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
