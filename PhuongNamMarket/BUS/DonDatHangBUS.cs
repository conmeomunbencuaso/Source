using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class DonDatHangBUS
    {
        public DAO.DonDatHangDAO DonDatHangDAO { get; set; }

        public DonDatHangBUS()
        {
            this.DonDatHangDAO = new DonDatHangDAO();
        }

        public void TaoDonDatHang()
        {

        }

        public void CapNhatTrangThaiDonDatHang() {

        }

        public void CapNhatThongTinChiTietDonDatHang()
        {

        }

        public void XoaBoDonDatHang()
        {

        }

        public object LayDanhSachDonDatHang()
        {
            return DonDatHangDAO.LayDanhSachDonDatHang();
        }
    }
}
