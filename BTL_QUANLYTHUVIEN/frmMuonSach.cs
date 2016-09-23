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
    public partial class frmMuonSach : Form
    {
        public string maDG;
        public int check = 0;
        public frmMuonSach()
        {
            InitializeComponent();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            check = 0;
            if (DocGia_BUS.checkDG(tbMaDG.Text).Rows.Count>0)
            {
                maDG = tbMaDG.Text;
                check = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Độc giả không tồn tại!");
                tbMaDG.Clear();
                tbMaDG.Focus();
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
