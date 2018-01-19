using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPham
    {
        string tenLoaiSanPham;
        string maLoaiSanPham;

        public string MaLoaiSanPham { get => maLoaiSanPham; set => maLoaiSanPham = value; }
        public string TenLoaiSanPham { get => tenLoaiSanPham; set => tenLoaiSanPham = value; }
    }
}
