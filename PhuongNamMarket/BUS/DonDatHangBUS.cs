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

        public object LayDanhSachDonDatHang()
        {
            return DonDatHangDAO.LayDanhSachDonDatHang();
        }

        public DataTable LayMaDonDatHangCuoi()
        {
            return DonDatHangDAO.LayMaDonDatHangCuoi();
        }

        public object TimKiemDonDatHang(string maDDH, string maNCC, string maTT)
        {
            return DonDatHangDAO.TimKiemDonDatHang(maDDH, maNCC, maTT);
        }

        public object TaoDonDatHang(string maDDH, string ngayLap, string maNCC, string maTT)
        {
            return DonDatHangDAO.TaoDonDatHang(maDDH, ngayLap, maNCC, maTT);
        }

        public object SuaDonDatHang(string maDDH, string ngayLap, string maNCC, string maTT)
        {
            return DonDatHangDAO.SuaDonDatHang(maDDH, ngayLap, maNCC, maTT);
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
