using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        public DataProvider Provider { get; set; }

        public NhanVienDAO()
        {
            Provider = new DataProvider();
        }

        public DataTable DangNhap(string id, string pass)
        {
            var query = @"SELECT * FROM NhanVien WHERE MaNhanVien = '" + id + "' and MatKhau = '" + pass + "'";

            var nhanVien = Provider.GetTable(query);
            return nhanVien;
        }
    }
}
