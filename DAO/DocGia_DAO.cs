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
    public class DocGia_DAO
    {
        public static DataTable DanhSachDG()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSDocGia").Tables[0];
            cnn.Close();
            return dtb;
        }
        public static string LastMaDG()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_lastMaDG").Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
        public static void themDG(string maDG, string tenDG, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt, DateTime nct, DateTime nht, string donVi)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_themDG", maDG, tenDG, gioiTinh, ngaySinh, diaChi, sdt, nct, nht, donVi);
            cnn.Close();
            //   DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_themSV").Tables[0];
        }
        public static void suaDG_Ten(string ma, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_TEN", ma, s);
            cnn.Close();
        }
        public static void suaDG_gt(string ma, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_gt", ma, s);
            cnn.Close();
        }
        public static void suaDG_dc(string ma, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_dc", ma, s);
            cnn.Close();
        }
        public static void suaDG_dv(string ma, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_dv", ma, s);
            cnn.Close();
        }
        public static void suaDG_sdt(string ma, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_sdt", ma, s);
            cnn.Close();
        }
        public static void suaDG_ns(string ma, DateTime s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_ns", ma, s);
            cnn.Close();
        }
        public static void suaDG_nct(string ma, DateTime s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_nct", ma, s);
            cnn.Close();
        }
        public static void suaDG_nhh(string ma, DateTime s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_nhh", ma, s);
            cnn.Close();
        }
        public static void xoaDG(string ma)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_xoaDG", ma);
            cnn.Close();
        }
        public static DataTable checkDG(string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_checkDG", s).Tables[0];
            cnn.Close();
            return dtb;
        }
        public static DataTable dsMaDG()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSMADG").Tables[0];
            cnn.Close();
            return dtb;
        }
        public static string TenDG(string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_tenDG", s).Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
    }
}
