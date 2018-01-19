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
        public DataProvider dataProvider { get; set; }

        public NhaCungCapDAO()
        {
            dataProvider = new DataProvider();
        }

        public DataTable LayDanhSachNhaCungCap()
        {
            return dataProvider.GetDataTable("NhaCungCap");
        }

        public DataTable LayDanhSachSanPhamTheoNhaCungCap(string maNhaCungCap)
        {
            var query = String.Format(@"SELECT sp.MaSanPham,sp.TenSanPham,sp.GiaMua,ncc.MaNhaCungCap,ncc.TenNhaCungCap
                                        FROM NhaCungCap ncc join SanPham sp on ncc.MaNhaCungCap = sp.MaNhaCungCap
                                        WHERE ncc.MaNhaCungCap ='{0}'", maNhaCungCap);
            return dataProvider.GetTable(query);
        }
    }
}
