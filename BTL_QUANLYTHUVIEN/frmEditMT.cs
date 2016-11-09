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
    public partial class frmEditMT : Form
    {
        public string maMT, tenDS, maSach, maDG, maNV,ghiChu,tenDG;
        public DateTime ngayM, hanTra, ngayT;
        public int check;
        public bool checkT=false;
        public frmEditMT()
        {
            InitializeComponent();
        }
        public void load_new()
        {
            ngayM=new DateTime();
            ngayT=new DateTime();
            ngayM=new DateTime();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            maMT = tbMaMT.Text;
            tenDS = cboTenDS.Text;
            maSach = cboMaSach.Text;
            maDG = cboMaDG.Text;
            tenDG = tbTenDG.Text;
            maNV = cboNV.Text;
            ghiChu = tbGhiChu.Text;
            ngayM = dtpNgayM.Value;
            if (chkNgayTra.Checked)
            {
                checkT = true;
                ngayT = dtpNgayT.Value;
            }
            hanTra = dtpNgayHH.Value;
            this.Close();
        }
        public void loadInfo()
        {
            chkNgayTra.Checked = false;
            dtpNgayT.Enabled = false;
            tbMaMT.Text = maMT;
            cboTenDS.Text = tenDS;
            cboMaDG.Text = maDG;
            cboNV.Text = maNV;
            tbGhiChu.Text = ghiChu;
            cboMaSach.Text = maSach;
            if (ngayM != DateTime.MinValue) dtpNgayM.Value = ngayM;
            if (ngayT != DateTime.MinValue)
            {
                //checkT = true;
                chkNgayTra.Checked = true;
                dtpNgayT.Value = ngayT;                
                dtpNgayT.Enabled = true;
                
            }
            if (hanTra != DateTime.MinValue)
            {
                
                dtpNgayHH.Value = hanTra;
            }
            int sl = cboTenDS.Items.Count;
            for (int i = 0; i < sl; i++)
                cboTenDS.Items.RemoveAt(0);
            DataTable dtb = DauSach_BUS.dsTenDS();
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                // string name = dtb.Rows[i][0].ToString().ToUpper();
                string name = dtb.Rows[i][0].ToString();
                cboTenDS.Items.Add(name);
            }
            sl = cboMaDG.Items.Count;
            for (int i = 0; i < sl; i++)
                cboMaDG.Items.RemoveAt(0);
            dtb = DocGia_BUS.dsMaDG();
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                // string name = dtb.Rows[i][0].ToString().ToUpper();
                string name = dtb.Rows[i][0].ToString();
                cboMaDG.Items.Add(name);
            }
            sl = cboMaSach.Items.Count;
            for (int i = 0; i < sl; i++)
                cboMaSach.Items.RemoveAt(0);
            dtb = Sach_BUS.dsmaSach(tenDS);
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                // string name = dtb.Rows[i][0].ToString().ToUpper();
                string name = dtb.Rows[i][0].ToString();
                cboMaSach.Items.Add(name);
            }
            sl = cboNV.Items.Count;
            for (int i = 0; i < sl; i++)
                cboNV.Items.RemoveAt(0);
            dtb = NhanVien_BUS.dsMaNV();
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                // string name = dtb.Rows[i][0].ToString().ToUpper();
                string name = dtb.Rows[i][0].ToString();
                cboNV.Items.Add(name);
            }
            if(maDG!="")
                tbTenDG.Text = DocGia_BUS.TenDG(maDG);
        }

        private void cboTenDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sl = cboMaSach.Items.Count;
            for (int i = 0; i < sl; i++)
                cboMaSach.Items.RemoveAt(0);
            DataTable dtb = Sach_BUS.dsmaSach(cboTenDS.Text);
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                // string name = dtb.Rows[i][0].ToString().ToUpper();
                string name = dtb.Rows[i][0].ToString();
                cboMaSach.Items.Add(name);
            }
            if (cboMaSach.Items.Count >= 0) cboMaSach.SelectedIndex = 0;
        }

        private void cboMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTenDG.Text = DocGia_BUS.TenDG(cboMaDG.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chkNgayTra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNgayTra.Checked)
            {
                checkT = true;
                dtpNgayT.Enabled = true;
            }
            else
            {
                dtpNgayT.Enabled = false;
                checkT = false;
            }
        }
    }
}
