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
    public class KetNoi_BUS
    {
        public static int KetNoi()
        {
            return sqlConnectionData.connection() == null ? 0 : 1;
        }
    }
}
