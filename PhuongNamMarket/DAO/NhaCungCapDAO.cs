using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaCungCapDAO
    {
        public DataProvider Provider { get; set; }

        public NhaCungCapDAO()
        {
            Provider = new DataProvider();
        }

        public DataTable LayDanhSachNhaCungCap()
        {
            //var query = @"SELECT * FROM NhaCungCap";
            return Provider.GetDataTable("NhaCungCap");            
        }
    }
}
