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
    public class TheLoai_DAO
    {
        //Load danh sách thể loại
        public static DataTable LoadDSTheLoai()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSTheLoai").Tables[0];
            cnn.Close();
            return dtb;

        }
        //lấy mã TL cuối cùng
        public static string LastMaTL()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_lastMaTL").Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
        //thêm THỂ LOẠI
        public static void themTL(string maTL, string tenTL)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_themTL", maTL, tenTL);
            cnn.Close();
            //   DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_themSV").Tables[0];
        }
        //SỬA TÊN THỂ LOẠI
        public static void suaTL(string maTL, string tenTL)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaTenTL", maTL, tenTL);
            cnn.Close();
        }
        //XÓA mã thể loại
        public static void xoaTL(string maTL)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_xoaTL", maTL);
            cnn.Close();
        }
        public static DataTable DStenTL()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DStenTL").Tables[0];
            cnn.Close();
            return dtb;
        }
        public static string MaTL(string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_maTL", s).Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
    }
}
