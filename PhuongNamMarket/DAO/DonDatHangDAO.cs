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
            var dsDonDatHang = Provider.GetDataTable("DonDatHang");
            return dsDonDatHang;
        }
    }
}
