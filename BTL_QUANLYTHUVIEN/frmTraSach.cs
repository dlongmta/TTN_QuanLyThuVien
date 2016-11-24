using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace BTL_QUANLYTHUVIEN
{
    
    public partial class frmTraSach : Form
    {
        public string maSach = "",ghiChu="";
        public int check = 0;
        public frmTraSach()
        {
            InitializeComponent();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (MuonTra_BUS.checkTraSach(tbMaSach.Text).Rows.Count > 0)
            {
                maSach = tbMaSach.Text;
                check = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sách không tồn tại!");
                check = 0;
                tbMaSach.Clear();
                tbGhiChu.Clear();
            }
        }
    }
}
