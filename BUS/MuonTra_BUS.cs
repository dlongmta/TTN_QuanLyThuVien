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
    public class MuonTra_BUS
    {
        public static void muonSach(string maMT, string maNV, string maDG, DateTime ngayMuon, DateTime hanTra, string maSach)
        {
            MuonTra_DAO.muonSach(maMT, maNV, maDG, ngayMuon, hanTra, maSach);
        }
        public static string LastMaMT()
        {
            return MuonTra_DAO.LastMaMT();
        }
        public static DataTable checkTraSach(string s)
        {
            return MuonTra_DAO.checkTraSach(s);
        }
        public static void TraSach(string ma, string ghichu, DateTime ngaytra)
        {
            MuonTra_DAO.TraSach(ma, ghichu, ngaytra);
        }
        public static DataTable DsMuonTra()
        {
            return MuonTra_DAO.DsMuonTra();
        }
        public static void xoaMT(string ma)
        {
            MuonTra_DAO.xoaMT(ma);
        }
        public static void suaMT_datra(string ma, string S, string DG, string NV, string gc, DateTime nm, DateTime nt, DateTime ht)
        {
            MuonTra_DAO.suaMT_datra(ma, S, DG, NV, gc, nm, nt, ht);
        }
        public static void suaMT_damuon(string ma, string S, string DG, string NV, string gc, DateTime nm, DateTime ht)
        {
            MuonTra_DAO.suaMT_damuon(ma, S, DG, NV, gc, nm, ht);

        }
        public static void themMT(string ma, string S, string DG, string NV, string gc, DateTime nm, DateTime ht)
        {
            MuonTra_DAO.themMT(ma, S, DG, NV, gc, nm, ht);
        }
    }

}
