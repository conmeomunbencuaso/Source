using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

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
    }
}
