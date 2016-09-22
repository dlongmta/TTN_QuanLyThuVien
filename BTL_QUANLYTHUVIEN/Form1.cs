using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;

namespace BTL_QUANLYTHUVIEN
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region các biến
        public string maNV;
        public int chucVu = -1;
        public frmLogin dn = null;
        #endregion
        AddTab.TabAdd clsAddTab = new AddTab.TabAdd(); 
        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();
            if (chucVu >= 0)
                AnMenu(true, chucVu);
            else AnMenu(false, 0);
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbSkins, true);
            defaultLookAndFeel1.LookAndFeel.SetSkinStyle("Black");
            //   DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.BonusSkins).Assembly);
            //   DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.OfficeSkins).Assembly);       

        }
        #region Các hàm xử lý login và phân quyền

        public void AnMenu(bool logged, int QuyenHan = 1)
        {
            //Mac dinh la dang nhap thanh cong bat het cac Menu

            //
            //  string s = "SV0020";
            //string sub1 = s.Substring(0, 2);
            //string sub2 = s.Substring(2);
            //int ma = Convert.ToInt32(sub2) + 1;
            //string sub = "";
            //for (int i = 0; i < sub2.Length - ma.ToString().Length; i++)
            //    sub += "0";
            //sub += ma.ToString();
            //sub1 += sub;
            //return sub1 + sub;
            //   MessageBox.Show(s + " " + sub1);
            //MessageBox.Show(Convert.ToInt32("0010001").ToString());
           // btnThongTinBanThan.Enabled = logged;
            //btnDoiMatKhau.Enabled = logged;
            btnDauSach.Enabled = logged;
            btnKho.Enabled = logged;
            //  btnThoat.Enabled = logged;
            btnDocGia.Enabled = logged;
            btnNhanVien.Enabled = logged;
            btnMuonTra.Enabled = logged;
           // btnTraSach.Enabled = logged;
          //  btnLop.Enabled = logged;
            //btnPhanQuyen.Enabled = logged;
            //btnLopHocPhan.Enabled = logged;
            xtraTabControl1.Enabled = logged;
            switch (QuyenHan)
            {
                case 1: break;
                case 0: HienThiNhanVien(); break;
            }
        }

        //  Hiển thị Menu với nhóm "Nhân Viên"
        private void HienThiNhanVien()
        {
            btnNhanVien.Enabled = false;
        }

        #endregion

   
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControl1.TabPages.RemoveAt(xtraTabControl1.SelectedTabPageIndex);
        }

        private void xtraTabControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
        }

        private void btnDauSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            AnMenu(false);
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
     
       
        }

        private void btnMuonTra_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
    }
}
