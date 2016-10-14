using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DTO;
namespace DAO
{
    public class MuonTra_DAO
    {
        public static void muonSach(string maMT, string maNV, string maDG, DateTime ngayMuon, DateTime hanTra, string maSach)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_muonSach", maMT, maNV, maDG, ngayMuon, hanTra, maSach);
            cnn.Close();
        }
        public static string LastMaMT()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_lastMaMT").Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
        public static DataTable checkTraSach(string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_checkSach", s).Tables[0];
            cnn.Close();
            return dtb;
        }
        public static void TraSach(string ma, string ghichu, DateTime ngaytra)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_traSach", ma, ghichu, ngaytra);
            cnn.Close();
        }
        public static DataTable DsMuonTra()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSMuonTra").Tables[0];
            cnn.Close();
            return dtb;
        }
        public static void xoaMT(string ma)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_xoaMT", ma);
            cnn.Close();
        }
        public static void suaMT_datra(string ma, string S, string DG, string NV, string gc, DateTime nm, DateTime nt, DateTime ht)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaMT_DATRA", ma, S, DG, NV, gc, nm, nt, ht);
            cnn.Close();
        }
        public static void suaMT_damuon(string ma, string S, string DG, string NV, string gc, DateTime nm, DateTime ht)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaMT_DAmuon", ma, S, DG, NV, gc, nm, ht);
            cnn.Close();
        }
        public static void themMT(string ma, string S, string DG, string NV, string gc, DateTime nm, DateTime ht)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_themMT", ma, S, DG, NV, gc, nm, ht);
            cnn.Close();
        }

    }
}
