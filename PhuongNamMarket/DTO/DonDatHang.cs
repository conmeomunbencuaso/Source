using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonDatHang
    {
        private string maDonDatHang;
        private string ngayLap;
        private int maTrangThai;
        private string maNhaCungCap;

        
        public DonDatHang()
        { }

        public DonDatHang(string maDonDatHang, string ngayLap, int maTrangThai, string maNhaCungCap)
        {
            this.maDonDatHang = maDonDatHang;
            this.ngayLap = ngayLap;
            this.maTrangThai = maTrangThai;
            this.maNhaCungCap = maNhaCungCap;
        }

        public string MaDonDatHang { get => maDonDatHang; set => maDonDatHang = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public int MaTrangThai { get => maTrangThai; set => maTrangThai = value; }
        public string MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }
    }
}
