using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        public DataProvider Provider { get; set; }

        public SanPhamDAO()
        {
            Provider = new DataProvider();
        }

        public DataTable LayDanhSachSanPhamChoDatHang()
        {
            var query = @"SELECT MaSanPham, TenSanPham, GiaMua, TenNhaCungCap, sp.MaNhaCungCap
                        FROM SanPham sp join NhaCungCap ncc on sp.MaNhaCungCap = ncc.MaNhaCungCap";

            var dsSanPham = Provider.GetTable(query);
            return dsSanPham;
        }


    }
}
