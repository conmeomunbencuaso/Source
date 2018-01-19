using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietDonDatHangDAO
    {
        public DataProvider Provider { get; set; }

        public ChiTietDonDatHangDAO()
        {
            Provider = new DataProvider();
        }

        public bool TaoChiTietDonDatHang(string maDDH, string maSP, string soLuong)
        {
            var query = @"INSERT ChiTietDonDatHang(MaDonDatHang, MaSanPham, SoLuong)
                        VALUES('" + maDDH + "', '" + maSP + "', " + soLuong + ")";

            var taoChiTietDonDatHang = Provider.ExecuteUpdateQuery(query);
            return taoChiTietDonDatHang;
        }

    }
}
