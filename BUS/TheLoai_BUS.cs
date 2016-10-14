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
    public class TheLoai_BUS
    {
        public static int KetNoi()
        {
            return sqlConnectionData.connection() == null ? 0 : 1;
        }
        //Load danh sách sinh viên
        public static DataTable DanhSachTL()
        {
            return TheLoai_DAO.LoadDSTheLoai();
        }
        public static string LastMaTL()
        {
            return TheLoai_DAO.LastMaTL();
        }
        public static void themTL(string maTL,string tenTL)
        {
            TheLoai_DAO.themTL(maTL, tenTL);
        }
        public static void suaTL(string maTL, string tenTL)
        {
            TheLoai_DAO.suaTL(maTL, tenTL);
        }
        public static void xoaTL(string maTL)
        {
            TheLoai_DAO.xoaTL(maTL);
        }
        public static DataTable DStenTL()
        {
            return TheLoai_DAO.DStenTL();
        }
        public static string MaTL(string s)
        {
            return TheLoai_DAO.MaTL(s);
        }
    }

}
