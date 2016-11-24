using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVien_BUS
    {
        public static DataTable login(string s, string s2)
        {
            return NhanVien_DAO.login(s, s2);
        }
        public static DataTable dsMaNV()
        {
            return NhanVien_DAO.dsMaNV();
        }
        public static DataTable DanhSachNV()
        {
            return NhanVien_DAO.DanhSachNV();
        }
        public static string LastMaNV()
        {
            return NhanVien_DAO.LastMaNV();
        }
        public static void themNV(string maNV, string tenNV, string gioiTinh, string phanQuyen, string pw)
        {
            NhanVien_DAO.themNV(maNV, tenNV, gioiTinh, phanQuyen, pw);
            //   DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_themSV").Tables[0];
        }
        public static void suaNV(string maNV, string tenNV, string gioiTinh, string phanQuyen, string pw)
        {
            NhanVien_DAO.suaNV(maNV, tenNV, gioiTinh, phanQuyen, pw);
            //   DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_themSV").Tables[0];
        }
        public static string MaQuyenNV(string ma)
        {
            return NhanVien_DAO.MaQuyenNV(ma);
        }
        public static void xoaNV(string maNV)
        {
            NhanVien_DAO.xoaNV(maNV);
        }
    }
}
