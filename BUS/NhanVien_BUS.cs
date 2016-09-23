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
    public class NhanVien_BUS
    {
        public static DataTable login(string s, string s2)
        {
            return NhanVien_DAO.login(s, s2);
        }
        public static DataTable dsMaNV()
        {
            return NhanVien_DAO.dsMaNV();
        }
    }
}
