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
    public class sqlConnectionData
    {
        public static SqlConnection connection()
        {
            SqlConnection cnn = new SqlConnection("Data Source=MAX-PC\\SQLEXPRESS;Initial Catalog=BTL_QuanLyThuVien;Integrated Security=True");
            return cnn;
        }
    }

    
   
   
  
}
