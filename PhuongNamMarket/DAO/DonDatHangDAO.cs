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

        public void CapNhatTrangThaiDonDatHang()
        {

        }

        public void CapNhatThongTinChiTietDonDatHang()
        {

        }

        public void XoaBoDonDatHang()
        {

        }

        public DataTable LayDanhSachDonDatHang()
        {
            var query = @"SELECT MaDonDatHang,NgayLap,TenTrangThai,TenNhaCungCap FROM DonDatHang DDH JOIN TrangThaiDonDatHang TTDDH
                        ON DDH.MaTrangTrangThai = TTDDH.MaTrangThaiDonDatHang
                        JOIN NhaCungCap NCC ON DDH.MaNhaCungCap = NCC.MaNhaCungCap";

            var dsDonDatHang = Provider.GetTable(query);
            return dsDonDatHang;
        }
    }
}
