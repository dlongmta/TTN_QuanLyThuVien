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
    public class DocGia_BUS
    {
        public static DataTable DanhSachDG()
        {
            return DocGia_DAO.DanhSachDG();
        }
        public static string LastMaDG()
        {
            return DocGia_DAO.LastMaDG();
        }
        public static void themDG(string maDG, string tenDG, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt, DateTime nct, DateTime nht, string donVi)
        {
            DocGia_DAO.themDG(maDG, tenDG, gioiTinh, ngaySinh, diaChi, sdt, nct, nht, donVi);
            //   DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_themSV").Tables[0];
        }
        public static void suaDG_Ten(string ma, string s)
        {
            DocGia_DAO.suaDG_Ten(ma, s);
        }
        public static void suaDG_gt(string ma, string s)
        {
            DocGia_DAO.suaDG_gt(ma, s);
        }
        public static void suaDG_dc(string ma, string s)
        {
            DocGia_DAO.suaDG_dc(ma, s);
        }
        public static void suaDG_dv(string ma, string s)
        {
            DocGia_DAO.suaDG_dv(ma, s);
        }
        public static void suaDG_sdt(string ma, string s)
        {
            DocGia_DAO.suaDG_sdt(ma, s);
        }
        public static void suaDG_ns(string ma, DateTime s)
        {
            DocGia_DAO.suaDG_ns(ma, s);
        }
        public static void suaDG_nct(string ma, DateTime s)
        {
            DocGia_DAO.suaDG_nct(ma, s);
        }
        public static void suaDG_nhh(string ma, DateTime s)
        {
            DocGia_DAO.suaDG_nhh(ma, s);
        }
        public static void xoaDG(string ma)
        {
            DocGia_DAO.xoaDG(ma);
        }
        public static DataTable checkDG(string s)
        {
            return DocGia_DAO.checkDG(s);
        }
        public static DataTable dsMaDG()
        {
            return DocGia_DAO.dsMaDG();
        }
        public static string TenDG(string s)
        {
            return DocGia_DAO.TenDG(s);
        }

    }
}
