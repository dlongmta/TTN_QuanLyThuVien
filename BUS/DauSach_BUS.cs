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
    public class DauSach_BUS
    {
        public static DataTable LoadDSDauSach()
        {
            return DauSach_DAO.LoadDSDauSach();

        }
        public static string LastMaDS()
        {
            return DauSach_DAO.LastMaDS();
        }
        public static void themDS(string maDS, string tenDS, string maTL, string tenTG, string NXB, string giaSach, int sl1, int sl2)
        {
            DauSach_DAO.themDS(maDS, tenDS, maTL, tenTG, NXB, giaSach, sl1, sl2);
        }
        public static void suaDS_ten(string maDS, string s)
        {
            DauSach_DAO.suaDS_ten(maDS, s);
        }
        public static void suaDS_tl(string maDS, string s)
        {
            DauSach_DAO.suaDS_tl(maDS, s);
        }
        public static void suaDS_tg(string maDS, string s)
        {
            DauSach_DAO.suaDS_tg(maDS, s);
        }
        public static void suaDS_nxb(string maDS, string s)
        {
            DauSach_DAO.suaDS_nxb(maDS, s);
        }
        public static void suaDS_giasach(string maDS, string s)
        {
            DauSach_DAO.suaDS_giasach(maDS, s);
        }
        public static void xoaDS(string maDS)
        {
            DauSach_DAO.xoaDS(maDS);
        }
        public static DataTable dsTenDS()
        {
            return DauSach_DAO.dsTenDS();
        }
    }
}
