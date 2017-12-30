using System;
using System.Collections.Generic;
using System.Data;
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

        public object LayDanhSachDonDatHang()
        {
            return DonDatHangDAO.LayDanhSachDonDatHang();
        }

        public object TimKiemDonDatHang(string maDDH, string maNNC, string maTT)
        {
            return DonDatHangDAO.TimKiemDonDatHang(maDDH, maNNC, maTT);
        }

        public object SuaDonDatHang(string maDDH, string ngayLap, string maNNC, string maTT)
        {
            return DonDatHangDAO.SuaDonDatHang(maDDH, ngayLap, maNNC, maTT);
        }

        public object XoaDonDatHang(string maDDH)
        {
            return DonDatHangDAO.XoaDonDatHang(maDDH);
        }

        public DataTable LayDanhSachTrangThaiDonDatHang()
        {
            return DonDatHangDAO.LayDanhSachTrangThaiDonDatHang();
        }
    }
}
