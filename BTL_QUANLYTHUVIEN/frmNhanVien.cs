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
    public partial class frmNhanVien : Form
    {
        #region các biến
        public bool them = true;
        public bool sua = false;
        public bool daChuanhoa = false;
        #endregion
        public frmNhanVien()
        {
            InitializeComponent();
            Enabled(false);
        }
        public void Enabled(bool logged)
        {
            //Mac dinh la dang nhap thanh cong bat het cac Menu

            //
            btnThem.Enabled = logged;
            btnSua.Enabled = logged;
            btnXoa.Enabled = logged;
            //  btnThoat.Enabled = logged;
            // btnXuatExcel.Enabled = logged;
            //btnNhapExcel.Enabled = logged;
            // btnXemDiem.Enabled = logged;
            //btnCapNhat.Enabled = logged;
            btnLuu.Enabled = logged;
            btnHuy.Enabled = logged;
            // btnDSMuon.Enabled = logged;
        }
        public void load()
        {
            NVbindingSource.DataSource = NhanVien_BUS.DanhSachNV();
            gcNhanVien.DataSource = NVbindingSource;
        }

        private void btnDSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Enabled(true);
            load();
        }

        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (them)
            {
                tbTenNV.Clear();
                string maNV = nextMa(NhanVien_BUS.LastMaNV());
                //
                them = false;
                NVbindingSource.AddNew();
                //mã sinh viên tự tăng
                gvNhanVien.SetFocusedRowCellValue(colMaNV, maNV);
                tbMaNV.Text = maNV;
                cboPhanQuyen.SelectedIndex = 1;
                //trỏ tới dòng cuối cùng trong gridview
                gvNhanVien.FocusedRowHandle = gvNhanVien.RowCount - 1;
                tbTenNV.Focus();

            }
            else
            {
                gvNhanVien.FocusedRowHandle = gvNhanVien.RowCount - 1;
                tbTenNV.Focus();
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


        private void gvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvNhanVien.FocusedRowHandle >= 0)
            {
                tbMaNV.Text = gvNhanVien.GetFocusedRowCellValue(colMaNV).ToString();
                tbTenNV.Text = gvNhanVien.GetFocusedRowCellValue(colTenNV).ToString();
                //ToUpper để convert sang chữ in hoa
                if (gvNhanVien.GetFocusedRowCellValue(colGioiTinh).ToString().ToUpper() == "NAM") cboGioiTinh.SelectedIndex = 0;
                else cboGioiTinh.SelectedIndex = 1;
                if (gvNhanVien.GetFocusedRowCellValue(colPhanQuyen).ToString().ToUpper().Trim() == "ADMIN")
                {
                    cboPhanQuyen.SelectedIndex = 0;
                    cboPhanQuyen.Enabled = false;
                }
                else
                {
                    cboGioiTinh.SelectedIndex = 1;
                    cboPhanQuyen.Enabled = true;
                } 
                tbPW.Text = gvNhanVien.GetFocusedRowCellValue(colpw).ToString();
                
                sua = false;
            }
        }
        public string ChuanHoa(string st)
        {
            string st1 = "";
            st = st.Trim();
            while (st.Length != 0)
            {
                st += " ";
                int i = st.IndexOf(' ');
                string s = char.ToUpper(st[0]) + st.Substring(1, i);
                st1 += s;
                st = st.Substring(i + 1).Trim();
            }
            return st1.Trim();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!them && gvNhanVien.FocusedRowHandle == gvNhanVien.RowCount - 1)
                {
                    if (tbTenNV.Text != ""&&tbPW.Text!="")
                    {
                        //chuẩn hóa tên
                        string maNV = tbMaNV.Text;
                        string tenNV = ChuanHoa(tbTenNV.Text.ToLower());
                        string gioiTinh = cboGioiTinh.Text;
                        string phanQuyen = cboPhanQuyen.Text;
                        string pw = tbPW.Text;
                        NhanVien_BUS.themNV(maNV, tenNV, gioiTinh,phanQuyen,pw);
                        MessageBox.Show("Thêm thành công");
                        // this.SinhVienbindingSource.EndEdit();
                        //thêm trực tiếp sinh viên vào gridview mà không load lại danh sách
                        gvNhanVien.SetFocusedRowCellValue(colTenNV, tenNV);
                        gvNhanVien.SetFocusedRowCellValue(colGioiTinh, gioiTinh);
                        gvNhanVien.SetFocusedRowCellValue(colPhanQuyen, phanQuyen);
                        gvNhanVien.SetFocusedRowCellValue(colpw, pw);
                        //load_DS();
                        //chuẩn hóa ở textbox
                        tbTenNV.Text = tenNV;
                        
                        //
                        them = true;
                    }
                    else
                        MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            string maNV = tbMaNV.Text;
                            string tenNV = ChuanHoa(tbTenNV.Text.ToLower());
                            string gioiTinh = cboGioiTinh.Text;
                            string phanQuyen = cboPhanQuyen.Text;
                            string pw = tbPW.Text;
                            NhanVien_BUS.suaNV(maNV, tenNV, gioiTinh, phanQuyen, pw);

                            load();
                            MessageBox.Show("Sửa thành công!");
                            sua = true;
                        }
                        catch
                        {
                            MessageBox.Show("Sửa không thành công");
                        }
                    }
                    else
                    {
                        load();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (!them && gvNhanVien.FocusedRowHandle == gvNhanVien.RowCount - 1)
            {
                them = true;
                NVbindingSource.RemoveAt(gvNhanVien.RowCount - 1);
            }
            //hủy khi sửa
            else
            {
                load();
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //NhanVien_BUS.xoaSV(gvNhanVien.GetFocusedRowCellValue(colMaSV).ToString());
                NhanVien_BUS.xoaNV(gvNhanVien.GetFocusedRowCellValue(colMaNV).ToString());
                NVbindingSource.RemoveAt(gvNhanVien.FocusedRowHandle);
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnCapNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbTenNV.Focus();
        }
    }
}
