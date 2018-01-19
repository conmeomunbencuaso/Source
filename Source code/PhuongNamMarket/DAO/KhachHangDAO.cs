using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        public DataProvider Provider { get; set; }

        public KhachHangDAO()
        {
            Provider = new DataProvider();
        }

        public DataTable LayDanhSachKhachHang()
        {
            var query = @"SELECT * FROM KhachHang";

            var dsKhachHang = Provider.GetTable(query);
            return dsKhachHang;
        }

        public DataTable LayMaKhachHangCuoiCung()
        {
            var query = @"SELECT TOP 1 MaKhachHang FROM KhachHang Order by MaKhachHang DESC";

            var maKhachHang = Provider.GetTable(query);
            return maKhachHang;
        }

        public bool ThemKhachHang(string maKH, string tenKH, string sdt, string diachi)
        {
            var query = @"INSERT INTO KhachHang(MaKhachHang, TenKhachHang, SoDienThoai, DiaChi, Diem)
                        VALUES('" + maKH + "', N'" + tenKH + "', " + sdt + ", N'" + diachi + "', 0)";

            var themKhachHang = Provider.ExecuteUpdateQuery(query);
            return themKhachHang;
        }

    }
}
