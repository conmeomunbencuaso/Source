using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class HoaDonBanHangBUS
    {

        public DAO.HoaDonBanHangDAO HoaDonBanHangDAO { get; set; }

        public HoaDonBanHangBUS()
        {
            this.HoaDonBanHangDAO = new HoaDonBanHangDAO();
        }

        public DataTable LayMaHoaDonBanHangCuoiCung()
        {
            return HoaDonBanHangDAO.LayMaHoaDonBanHangCuoiCung();
        }

        public bool TaoHoaDonBanHang(string maHDBH, string ngayLap, long tongTien, int trangThai, string maKH, string maNV)
        {
            return HoaDonBanHangDAO.TaoHoaDonBanHang(maHDBH, ngayLap, tongTien, trangThai, maKH, maNV);
        }

        public bool TaoChiTietHoaDonBanHang(string maSP, string maHDBH, string soLuong)
        {
            return HoaDonBanHangDAO.TaoChiTietHoaDonBanHang(maSP, maHDBH, soLuong);
        }
    }
}
