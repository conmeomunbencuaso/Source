using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        public DAO.NhanVienDAO NhanVienDAO { get; set; }

        public NhanVienBUS()
        {
            this.NhanVienDAO = new NhanVienDAO();
        }

        public bool DangNhap(string id, string pass)
        {
            if (NhanVienDAO.DangNhap(id, pass).Rows.Count > 0)
                return true;
            else return false;
        }
    }
}
