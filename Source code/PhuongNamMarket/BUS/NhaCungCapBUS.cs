using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class NhaCungCapBUS
    {
        public DAO.NhaCungCapDAO NhaCungCapDAO { get; set; }

        public NhaCungCapBUS()
        {
            this.NhaCungCapDAO = new NhaCungCapDAO();
        }

        public DataTable LayDanhSachNhaCungCap()
        {
            return NhaCungCapDAO.LayDanhSachNhaCungCap();
        }

        public DataTable LayDanhSachSanPhamTheoNhaCungCap(string maNhaCungCap)
        {
            return NhaCungCapDAO.LayDanhSachSanPhamTheoNhaCungCap(maNhaCungCap);
        }
    }
}
