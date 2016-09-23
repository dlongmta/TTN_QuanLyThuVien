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
    }
}
