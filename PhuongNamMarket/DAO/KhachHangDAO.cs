using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        public DataProvider Provider { get; set; }

        public KhachHangDAO()
        {
            Provider = new DataProvider();
        }

        public DataTable LayDanhSachKhachHang()
        {
            var query = @"SELECT * FROM KhachHang";

            var dsKhachHang = Provider.GetTable(query);
            return dsKhachHang;
        }
    }
}
