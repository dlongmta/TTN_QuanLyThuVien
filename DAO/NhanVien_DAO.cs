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

    public class NhanVien_DAO
    {
        public static DataTable login(string s, string s2)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_login", s, s2).Tables[0];
            cnn.Close();
            return dtb;
        }
        public static DataTable dsMaNV()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSMaNV").Tables[0];
            cnn.Close();
            return dtb;
        }
        public static DataTable DanhSachNV()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSNV").Tables[0];
            cnn.Close();
            return dtb;
        }
        public static string LastMaNV()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_lastMaNV").Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
        //mã quyền
        public static string MaQuyenNV(string ma)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_QuyenHan", ma).Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
        public static void themNV(string maNV, string tenNV, string gioiTinh, string phanQuyen, string pw)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_themNV", maNV, tenNV, gioiTinh, phanQuyen, pw);
            cnn.Close();
            //   DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_themSV").Tables[0];
        }
        public static void suaNV(string maNV, string tenNV, string gioiTinh, string phanQuyen, string pw)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaNV", maNV, tenNV, gioiTinh, phanQuyen, pw);
            cnn.Close();
            //   DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_themSV").Tables[0];
        }
        public static void xoaNV(string maNV)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_xoaNV", maNV);
            cnn.Close();
            //   DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_themSV").Tables[0];
        }
    }
}
