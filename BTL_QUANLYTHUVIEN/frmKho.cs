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
    public partial class frmKho : Form
    {
        #region các biến
        public bool them = true;
        public bool sua = false;
        public int soLuongSV = 0;
        public bool daChuanhoa = false;
        public string maNV = "";
        #endregion
        public frmKho(string s)
        {
            maNV = s;
            InitializeComponent();
            Enable(false);
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load();
            Enable(true);
        }
        public void Enable(bool logged)
        {
            btnThem.Enabled = logged;
            btnXoa.Enabled = logged;
            btnMuonSach.Enabled = logged;
            btnTraSach.Enabled = logged;
        }
        private void Load()
        {
            try
            {
                DSbindingSource.DataSource = DauSach_BUS.LoadDSDauSach();
                gcDauSach.DataSource = DSbindingSource;
                int soTL = repositoryItemComboBox1.Items.Count;
                for (int i = 0; i < soTL; i++)
                {
                    repositoryItemComboBox1.Items.RemoveAt(0);
                    //cboTheLoai.Items.RemoveAt(0);
                }
                // gcTheLoai.DataSource = TLbindingSource;
            }
            catch
            {
                MessageBox.Show("Load bị lỗi!");
            }
        }
        //tự tăng mã mượn trả
        public string nextMa2(string s)
        {
            string sub1 = s.Substring(0, 2);
            string sub2 = s.Substring(2).Trim();
            int ma = Convert.ToInt32(sub2) + 1;
            string sub = "";
            //chèn thêm các kí tự 0 vào mã
            for (int i = 0; i < sub2.Length - ma.ToString().Length; i++)
                sub += "0";
            sub += ma.ToString();
            sub1 += sub;
            //
            return sub1;
        }
        //Hàm tự tăng mã sách
        public string nextMa(string s)
        {
            string sub1 = s.Substring(0, 1);
            string sub2 = s.Substring(1).Trim();
            int ma = Convert.ToInt32(sub2) + 1;
            string sub = "";
            //chèn thêm các kí tự 0 vào mã
            for (int i = 0; i < sub2.Length - ma.ToString().Length; i++)
                sub += "0";
            sub += ma.ToString();
            sub1 += sub;
            //
            return sub1;
        }
        private void gvDauSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gvDauSach.FocusedRowHandle>=0)
            {
                string maDS=gvDauSach.GetFocusedRowCellValue(colMaDS).ToString();
                SbindingSource.DataSource = Sach_BUS.LoadDSSach(maDS);
                gcSach.DataSource = SbindingSource;
                tbTenDS.Text = gvDauSach.GetFocusedRowCellValue(colTenDS).ToString();
                gvSach.ViewCaption = tbTenDS.Text;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nbcDS.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded;
            them = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nbcDS.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed;
            if(!them)
            {
                string maDS = gvDauSach.GetFocusedRowCellValue(colMaDS).ToString();
                int sl = Convert.ToInt32(tbSoLuong.Text);
                for (int i = 1; i <= sl;i++ )
                {
                    string maSach = nextMa(Sach_BUS.LastMaSach());
                    Sach_BUS.themSach(maDS, maSach, "Tốt", "Không");
                    SbindingSource.DataSource = Sach_BUS.LoadDSSach(maDS);
                    gcSach.DataSource = SbindingSource;
                    Load();
                }
                MessageBox.Show("Thêm thành công!");
                them = true;
                tbSoLuong.Clear();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            nbcDS.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed;
            them = true;
            tbSoLuong.Clear();
        }

        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //TheLoai_BUS.xoaTL(gvDauSach.GetFocusedRowCellValue(colMaTL).ToString());
                Sach_BUS.xoaSach(gvSach.GetFocusedRowCellValue(colMaSach).ToString());
                SbindingSource.RemoveAt(gvSach.FocusedRowHandle);
                Load();
                MessageBox.Show("Xóa thành công!");
            }
        }
        public frmMuonSach dn = null;
        private void btnMuonSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(gvSach.FocusedRowHandle>=0)
            {
                string maDG = "";
                if (gvSach.GetFocusedRowCellValue(colTinhTrangMuon).ToString() == "Đã Mượn")
                    MessageBox.Show("Sách này đã mượn!");
                else if (gvSach.GetFocusedRowCellValue(colTinhTrang).ToString() != "Tốt")
                    MessageBox.Show("Sách đang hỏng!");
                else
                {
                Cont:
                    //Kiểm tra xem form DangNhap được mở hay đóng, nếu đóng thì tạo mới
                    if (dn == null || dn.IsDisposed)
                        dn = new frmMuonSach();
                    
                    //dn.ShowDialog();
                    //khi nhấn đăng nhập
                    if (dn.ShowDialog() == DialogResult.OK)
                    {
                        if (dn.check == 0) goto Cont;
                        //Set lại menu theo quyền  
                        else
                        {
                            maDG = dn.maDG;
                            string maMT=nextMa2(MuonTra_BUS.LastMaMT());
                            //string maNV="NV00001";
                            string maSach=gvSach.GetFocusedRowCellValue(colMaSach).ToString();
                            MuonTra_BUS.muonSach(maMT, maNV, maDG, DateTime.Now, DateTime.Now, maSach);
                            MessageBox.Show("Mượn hoàn tất");
                            //cập nhật trên gridview
                            Load();
                            gvSach.SetFocusedRowCellValue(colTinhTrangMuon, "Đã Mượn");
                        }
                    }
                    //khi nhấn thoát
                    else dn.Hide();
                }
            }
        }
        public frmTraSach dx = null;
        private void btnTraSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        Cont:
            //Kiểm tra xem form DangNhap được mở hay đóng, nếu đóng thì tạo mới
            if (dx == null || dx.IsDisposed)
                dx = new frmTraSach();
            //dn.ShowDialog();
            //khi nhấn đăng nhập
            if (dx.ShowDialog() == DialogResult.OK)
            {
                if (dx.check == 0) goto Cont;
                //Set lại menu theo quyền  
                else
                {
                    string maSach = dx.maSach;
                    MuonTra_BUS.TraSach(maSach, "", DateTime.Now);
                    MessageBox.Show("Trả hoàn tất");
                    //cập nhật trên gridview
                    Load();
                    string maDS = gvDauSach.GetFocusedRowCellValue(colMaDS).ToString();
                    SbindingSource.DataSource = Sach_BUS.LoadDSSach(maDS);
                    gcSach.DataSource = SbindingSource;
                }
            }
            //khi nhấn thoát
            else dx.Hide();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load();
            if (gvDauSach.FocusedRowHandle >= 0)
            {
                string maDS = gvDauSach.GetFocusedRowCellValue(colMaDS).ToString();
                SbindingSource.DataSource = Sach_BUS.LoadDSSach(maDS);
                gcSach.DataSource = SbindingSource;
                tbTenDS.Text = gvDauSach.GetFocusedRowCellValue(colTenDS).ToString();
                gvSach.ViewCaption = tbTenDS.Text;
            }
        }



  
    }
}
