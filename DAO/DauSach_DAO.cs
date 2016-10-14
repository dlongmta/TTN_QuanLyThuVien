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
    public class DauSach_DAO
    {
        public static DataTable LoadDSDauSach()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSDauSach").Tables[0];
            cnn.Close();
            return dtb;

        }
        //lấy mã DS cuối cùng
        public static string LastMaDS()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_lastMaDS").Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
        //thêm đầu sách
        public static void themDS(string maDS, string tenDS, string maTL, string tenTG, string NXB, string giaSach, int sl1, int sl2)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_ThemDS", maDS, tenDS, maTL, tenTG, NXB, giaSach, sl1, sl2);
            cnn.Close();
        }
        //sửa tên
        public static void suaDS_ten(string maDS, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDS_ten", maDS, s);
            cnn.Close();
        }
        public static void suaDS_tl(string maDS, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDS_tl", maDS, s);
            cnn.Close();
        }
        public static void suaDS_tg(string maDS, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDS_TG", maDS, s);
            cnn.Close();
        }
        public static void suaDS_nxb(string maDS, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDS_nxb", maDS, s);
            cnn.Close();
        }
        public static void suaDS_giasach(string maDS, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDS_giasach", maDS, s);
            cnn.Close();
        }
        //XÓA mã đầu sách
        public static void xoaDS(string maDS)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_xoaDS", maDS);
            cnn.Close();
        }
        //danh sách tên đầu sách
        public static DataTable dsTenDS()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DStenDS").Tables[0];
            cnn.Close();
            return dtb;
        }

    }
}
