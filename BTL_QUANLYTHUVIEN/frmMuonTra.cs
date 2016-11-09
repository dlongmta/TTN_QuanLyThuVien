﻿using System;
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
    public partial class frmMuonTra : Form
    {
        public frmEditMT dn=null;
        public bool them=true, sua=true;
        public frmMuonTra()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
           
        }

        private void btnDSMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Enable(true);
            Load();
        }
        public void Enable(bool logged)
        {
            //btnChuanHoa.Enabled = logged;
            btnCapNhap.Enabled = logged;
           // btnLuu.Enabled = logged;
           // btnHuy.Enabled = logged;
            btnThem.Enabled = logged;
            btnSua.Enabled = logged;
            btnXoa.Enabled = logged;

        }
        private void Load()
        {
            try
            {
                MTbindingSource.DataSource = MuonTra_BUS.DsMuonTra();
                gcMuonTra.DataSource = MTbindingSource;
                
                // gcTheLoai.DataSource = TLbindingSource;
            }
            catch
            {
                MessageBox.Show("Load bị lỗi!");
            }
        }

        private void btnCapNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //TheLoai_BUS.xoaTL(gvDauSach.GetFocusedRowCellValue(colMaTL).ToString());
                //Sach_BUS.xoaSach(gvSach.GetFocusedRowCellValue(colMaSach).ToString());
                MuonTra_BUS.xoaMT(gvMuonTra.GetFocusedRowCellValue(colMaMuonTra).ToString());
                MTbindingSource.RemoveAt(gvMuonTra.FocusedRowHandle);
               // Load();
                MessageBox.Show("Xóa thành công!");
            }
        }
        public string nextMa(string s)
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
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            them = false;   
                Cont:
                    //Kiểm tra xem form DangNhap được mở hay đóng, nếu đóng thì tạo mới
                    if (dn == null || dn.IsDisposed)
                        dn = new frmEditMT();
                    dn.load_new();
                    dn.maMT = nextMa(MuonTra_BUS.LastMaMT());
                    dn.tenDS = "";
                    dn.maSach = "";
                    dn.maDG = "";
                    dn.maNV = "";
                    dn.ghiChu = "";
                    dn.loadInfo();
                    //dn.ShowDialog();
                    //khi nhấn đăng nhập
                    if (dn.ShowDialog() == DialogResult.OK)
                    {
                        if (!sua)
                        {    //gọi hàm sửa
                            if (dn.checkT)
                            {
                                MuonTra_BUS.suaMT_datra(dn.maMT, dn.maSach, dn.maDG, dn.maNV, dn.ghiChu, dn.ngayM, dn.ngayT, dn.hanTra);
                            }
                            else MuonTra_BUS.suaMT_damuon(dn.maMT, dn.maSach, dn.maDG, dn.maNV, dn.ghiChu, dn.ngayM, dn.hanTra);
                            sua = true;
                            MessageBox.Show("Sửa thành công!");
                        }
                        else if (!them)
                        {
                            //gọi hàm thêm
                            MuonTra_BUS.themMT(dn.maMT, dn.maSach, dn.maDG, dn.maNV, dn.ghiChu, dn.ngayM, dn.hanTra);
                            them = true;
                            MessageBox.Show("Thêm thành công!");
                        }
                        Load();
                        //if (dn.check == 0) goto Cont;
                        ////Set lại menu theo quyền  
                        //else
                        //{
                        //    //maDG = dn.maDG;
                        //    //string maMT = nextMa2(MuonTra_BUS.LastMaMT());
                        //    //string maNV = "NV00001";
                        //    //string maSach = gvSach.GetFocusedRowCellValue(colMaSach).ToString();
                        //    //MuonTra_BUS.muonSach(maMT, maNV, maDG, DateTime.Now, DateTime.Now, maSach);
                        //    //MessageBox.Show("Mượn hoàn tất");
                        //    ////cập nhật trên gridview
                        //    //Load();
                        //    //gvSach.SetFocusedRowCellValue(colTinhTrangMuon, "Đã Mượn");
                        //}
                    }
                    //khi nhấn thoát
                    else dn.Close();
                
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvMuonTra.FocusedRowHandle >= 0)
            {
                sua = false;   
                Cont:
                    //Kiểm tra xem form DangNhap được mở hay đóng, nếu đóng thì tạo mới
                    if (dn == null || dn.IsDisposed)
                        dn = new frmEditMT();
                    dn.load_new();
                    dn.maMT=gvMuonTra.GetFocusedRowCellValue(colMaMuonTra).ToString();
                    dn.tenDS=gvMuonTra.GetFocusedRowCellValue(colTenDS).ToString();
                    dn.maSach=gvMuonTra.GetFocusedRowCellValue(colMaSach).ToString();
                    dn.maDG=gvMuonTra.GetFocusedRowCellValue(colMaDG).ToString();
                    dn.maNV=gvMuonTra.GetFocusedRowCellValue(colMaNV).ToString();
                    dn.ghiChu=gvMuonTra.GetFocusedRowCellValue(colGhiChu).ToString();
                    if(gvMuonTra.GetFocusedRowCellValue(colNgayMuon).ToString()!="")
                        dn.ngayM = DateTime.Parse(gvMuonTra.GetFocusedRowCellValue(colNgayMuon).ToString());
                    if (gvMuonTra.GetFocusedRowCellValue(colNgayTra).ToString() != "")
                        dn.ngayT = DateTime.Parse(gvMuonTra.GetFocusedRowCellValue(colNgayTra).ToString());
                    if (gvMuonTra.GetFocusedRowCellValue(colHanTra).ToString() != "")
                        dn.hanTra = DateTime.Parse(gvMuonTra.GetFocusedRowCellValue(colHanTra).ToString());
                    dn.loadInfo();
                    //dn.ShowDialog();
                    //khi nhấn đăng nhập
                    if (dn.ShowDialog() == DialogResult.OK)
                    {
                        if (!sua)
                        {    //gọi hàm sửa
                            if (dn.checkT)
                            {
                                MuonTra_BUS.suaMT_datra(dn.maMT, dn.maSach, dn.maDG, dn.maNV, dn.ghiChu, dn.ngayM, dn.ngayT, dn.hanTra);
                            }
                            else MuonTra_BUS.suaMT_damuon(dn.maMT, dn.maSach, dn.maDG, dn.maNV, dn.ghiChu, dn.ngayM, dn.hanTra);
                            sua = true;
                            MessageBox.Show("Sửa thành công!");
                        }
                        else if (!them)
                        {
                            //gọi hàm thêm
                            MuonTra_BUS.themMT(dn.maMT, dn.maSach, dn.maDG, dn.maNV, dn.ghiChu, dn.ngayM, dn.hanTra);
                            them = true;
                            MessageBox.Show("Thêm thành công!");
                        }
                        Load();
                        //if (dn.check == 0) goto Cont;
                        ////Set lại menu theo quyền  
                        //else
                        //{
                        //    //maDG = dn.maDG;
                        //    //string maMT = nextMa2(MuonTra_BUS.LastMaMT());
                        //    //string maNV = "NV00001";
                        //    //string maSach = gvSach.GetFocusedRowCellValue(colMaSach).ToString();
                        //    //MuonTra_BUS.muonSach(maMT, maNV, maDG, DateTime.Now, DateTime.Now, maSach);
                        //    //MessageBox.Show("Mượn hoàn tất");
                        //    ////cập nhật trên gridview
                        //    //Load();
                        //    //gvSach.SetFocusedRowCellValue(colTinhTrangMuon, "Đã Mượn");
                        //}
                    }
                    //khi nhấn thoát
                    else dn.Close();
                }
            
        }

        
    }
}