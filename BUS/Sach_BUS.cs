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
    public class Sach_BUS
    {
        public static DataTable LoadDSSach(string maDS)
        {
            return Sach_DAO.LoadDSSach(maDS);
        }
        public static string LastMaSach()
        {
            return Sach_DAO.LastMaSach();
        }
        public static void themSach(string maDS, string maSach, string tt, string ttm)
        {
            Sach_DAO.themSach(maDS, maSach, tt, ttm);
        }
        public static void xoaSach(string maSach)
        {
            Sach_DAO.xoaSach(maSach);
        }
        public static DataTable dsmaSach(string s)
        {
            return Sach_DAO.dsmaSach(s);
        }
    }
}
