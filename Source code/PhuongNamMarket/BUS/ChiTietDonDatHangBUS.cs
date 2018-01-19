using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class ChiTietDonDatHangBUS
    {
        public DAO.ChiTietDonDatHangDAO ChiTietDonDatHangDAO { get; set; }

        public ChiTietDonDatHangBUS()
        {
            this.ChiTietDonDatHangDAO = new ChiTietDonDatHangDAO();
        }

        public bool TaoChiTietDonDatHang(string maDDH, string maSP, string soLuong)
        {
            return ChiTietDonDatHangDAO.TaoChiTietDonDatHang(maDDH, maSP, soLuong);
        }

    }
}
