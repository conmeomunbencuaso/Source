using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangSanXuat
    {
        string maHangSanXuat;
        string tenHangSanXuat;

        public string TenHangSanXuat { get => tenHangSanXuat; set => tenHangSanXuat = value; }
        public string MaHangSanXuat { get => maHangSanXuat; set => maHangSanXuat = value; }
    }
}
