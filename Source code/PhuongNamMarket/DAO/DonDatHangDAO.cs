﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DonDatHangDAO
    {
        public DataProvider Provider { get; set; }

        public DonDatHangDAO()
        {
            Provider = new DataProvider();
        }

        public DataTable LayDanhSachDonDatHang()
        {
            var query = @"SELECT ddh.MaDonDatHang,NgayLap,ttddh.TenTrangThai,TenNhaCungCap
                        FROM DonDatHang ddh 
                        JOIN ChiTietDonDatHang ctddh on ddh.MaDonDatHang = ctddh.MaDonDatHang
                        JOIN SanPham sp on ctddh.MaSanPham = sp.MaSanPham
                        JOIN NhaCungCap ncc on sp.MaNhaCungCap = ncc.MaNhaCungCap
                        JOIN TrangThaiDonDatHang ttddh on ddh.MaTrangThai = ttddh.MaTrangThaiDonDatHang";
            var dsDonDatHang = Provider.GetTable(query);
            return dsDonDatHang;
        }

        public DataTable LayMaDonDatHangCuoiCung()
        {
            var query = @"SELECT TOP 1 MaDonDatHang FROM DonDatHang Order by MaDonDatHang DESC";

            var maDonDatHang = Provider.GetTable(query);
            return maDonDatHang;
        }

        public DataTable TimKiemDonDatHang(string maDDH, string maNCC, string maTT)
        {
            var query = @"SELECT MaDonDatHang,NgayLap,TenTrangThai,TenNhaCungCap FROM DonDatHang DDH 
                        JOIN TrangThaiDonDatHang TTDDH ON DDH.MaTrangTrangThai = TTDDH.MaTrangThaiDonDatHang
                        JOIN NhaCungCap NCC ON DDH.MaNhaCungCap = NCC.MaNhaCungCap
                        WHERE DDH.MaDonDatHang LIKE '%" + maDDH + "%' and DDH.MaNhaCungCap = '" + maNCC + "' and DDH.MaTrangTrangThai = " + maTT;

            var tkDonDatHang = Provider.GetTable(query);
            return tkDonDatHang;
        }

        public bool TaoDonDatHang(string maDDH, string ngayLap, string maTT, long tongTien)
        {
            var query = @"INSERT INTO DonDatHang(MaDonDatHang, NgayLap, MaTrangThai,TongTien)
                        VALUES('" + maDDH + "', '" + ngayLap + "', " + maTT+ "," + tongTien+")";

            var taoDonDatHang = Provider.ExecuteUpdateQuery(query);
            return taoDonDatHang;
        }

        public bool SuaDonDatHang(string maDDH, string ngayLap, string maTT)
        {
            var query = @"UPDATE DonDatHang 
            SET MaTrangTrangThai = " + maTT + ", NgayLap = '" + ngayLap + "' WHERE MaDonDatHang = '" + maDDH + "'";

            var suaDonDatHang = Provider.ExecuteUpdateQuery(query);
            return suaDonDatHang;
        }

        public bool XoaDonDatHang(string maDDH)
        {
            var query = @"DELETE DonDatHang WHERE MaDonDatHang = '" + maDDH + "'";

            var xoaDonDatHang = Provider.ExecuteUpdateQuery(query);
            return xoaDonDatHang;
        }

        public DataTable LayDanhSachTrangThaiDonDatHang()
        {
            return Provider.GetDataTable("TrangThaiDonDatHang");
        }
    }
}
