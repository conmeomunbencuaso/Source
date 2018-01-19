using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class KhachHangBUS
    {
        public DAO.KhachHangDAO KhachHangDAO { get; set; }

        public KhachHangBUS()
        {
            this.KhachHangDAO = new KhachHangDAO();
        }

        public object LayDanhSachKhachHang()
        {
            return KhachHangDAO.LayDanhSachKhachHang();
        }

        public DataTable LayMaKhachHangCuoiCung()
        {
            return KhachHangDAO.LayMaKhachHangCuoiCung();
        }

        public bool ThemKhachHang(string maKH, string tenKH, string sdt, string diachi)
        {
            return KhachHangDAO.ThemKhachHang(maKH, tenKH, sdt, diachi);
        }
    }
}
