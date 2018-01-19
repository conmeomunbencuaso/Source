using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonBanHangDAO
    {
        public DataProvider Provider { get; set; }

        public HoaDonBanHangDAO()
        {
            Provider = new DataProvider();
        }

        public DataTable LayMaHoaDonBanHangCuoiCung()
        {
            var query = @"SELECT TOP 1 MaHoaDonBanHang FROM HoaDonBanHang Order by MaHoaDonBanHang DESC";

            var maDonDatHang = Provider.GetTable(query);
            return maDonDatHang;
        }

        public bool TaoHoaDonBanHang(string maHDBH, string ngayLap, long tongTien, int trangThai, string maKH, string maNV)
        {
            var query = @"INSERT INTO HoaDonBanHang(MaHoaDonBanHang, NgayLap, TongTien, TrangThai, MaKhachHang, MaNhanVien)
                        VALUES('" + maHDBH + "', '" + ngayLap + "', " + tongTien + "," + trangThai + ", '" + maKH + "', '" + maNV + "')";

            var taoHoaDonBanHang = Provider.ExecuteUpdateQuery(query);
            return taoHoaDonBanHang;
        }

        public bool TaoChiTietHoaDonBanHang(string maSP, string maHDBH, string soLuong)
        {
            var query = @"INSERT ChiTietHoaDonBanHang(MaSanPham, MaHoaDonBanHang, SoLuong)
                        VALUES('" + maSP + "', '" + maHDBH + "', " + soLuong + ")";

            var taoChiTietHoaDonBanHang = Provider.ExecuteUpdateQuery(query);
            return taoChiTietHoaDonBanHang;
        }
    }
}
