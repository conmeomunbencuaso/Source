using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DonDatHangBUS
    {
        private NhanVien nhanVien;

        public DAO.DonDatHangDAO DonDatHangDAO { get; set; }

        public DonDatHangBUS()
        {
            this.DonDatHangDAO = new DonDatHangDAO();
        }

        public object LayDanhSachDonDatHang()
        {
            return DonDatHangDAO.LayDanhSachDonDatHang();
        }



        public object TimKiemDonDatHang(string maDDH, string maTT)
        {
            return DonDatHangDAO.TimKiemDonDatHang(maDDH, maTT);
        }

        

        public object SuaDonDatHang(string maDDH, string ngayLap, string maTT)
        {
            return DonDatHangDAO.SuaDonDatHang(maDDH, ngayLap, maTT);
        }

        public object XoaDonDatHang(string maDDH)
        {
            return DonDatHangDAO.XoaDonDatHang(maDDH);
        }

        public DataTable LayDanhSachTrangThaiDonDatHang()
        {
            return DonDatHangDAO.LayDanhSachTrangThaiDonDatHang();
        }

        public DataTable TaoMaDonDatHang()
        {
            return DonDatHangDAO.LayMaDonDatHangCuoiCung();
        }

        // tạo đơn đặt hàng
        public bool TaoDonDatHang(string maDDH, string ngayLap, string maTT, long tongTien)
        {
            return DonDatHangDAO.TaoDonDatHang(maDDH, ngayLap, maTT, tongTien);
        }

        // ràng buộc: tổng tiền tối đa của 1 đơn đặt hàng phải nhỏ hơn 500000000
        public bool KiemTraTongTienToiDaCuaDDH(long tongTienToiDa)
        {
            if (tongTienToiDa < 500000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // ràng buộc: số lượng sản phẩm tối thiểu của 1 đơn đặt hàng phải lớn hơn 0
        public bool KiemTraSLSPToithieuCuaDDH(int soLuongSanPhamToiThieu)
        {
            if (soLuongSanPhamToiThieu > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // cái này là giao diện nhưng lúc thầy nói đưa xuống nghiệp vụ luôn :)
        public bool KTSoLuongToiThieuCuaMotSanPham(int soLuongCuaMotSanPham)
        {
            if (soLuongCuaMotSanPham > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
