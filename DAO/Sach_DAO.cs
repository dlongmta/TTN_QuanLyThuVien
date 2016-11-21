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
    public class Sach_DAO
    {
        public static DataTable LoadDSSach(string maDS)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSSach", maDS).Tables[0];
            cnn.Close();
            return dtb;
        }
        public static string LastMaSach()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_lastMaSach").Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
        //thêm sách
        public static void themSach(string maDS, string maSach, string tt, string ttm)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_themSach", maDS, maSach, tt, ttm);
            cnn.Close();
            //   DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_themSV").Tables[0];
        }
        //XÓA mã sách
        public static void xoaSach(string maSach)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_xoaSach", maSach);
            cnn.Close();
        }
        public static DataTable dsmaSach(string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSMaSach", s).Tables[0];
            cnn.Close();
            return dtb;
        }

    }
}
