namespace BTL_QUANLYTHUVIEN
{
    partial class frmMuonTra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonTra));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDSMuon = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhap = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gcMuonTra = new DevExpress.XtraGrid.GridControl();
            this.gvMuonTra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaMuonTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colMaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHanTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrangMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MTbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.chkTenDG = new System.Windows.Forms.CheckBox();
            this.chkMaNV = new System.Windows.Forms.CheckBox();
            this.chkMaDG = new System.Windows.Forms.CheckBox();
            this.chkTenDauSach = new System.Windows.Forms.CheckBox();
            this.chkMaMT = new System.Windows.Forms.CheckBox();
            this.chkTatCa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMuonTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMuonTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MTbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.DrawGroupsBorder = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDSMuon,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnCapNhap});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1088, 75);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnDSMuon
            // 
            this.btnDSMuon.Caption = "Danh sách mượn trả";
            this.btnDSMuon.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDSMuon.Glyph")));
            this.btnDSMuon.Id = 1;
            this.btnDSMuon.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDSMuon.LargeGlyph")));
            this.btnDSMuon.Name = "btnDSMuon";
            this.btnDSMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSMuon_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 2;
            this.btnThem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThem.LargeGlyph")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSua.Glyph")));
            this.btnSua.Id = 3;
            this.btnSua.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSua.LargeGlyph")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 4;
            this.btnXoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.LargeGlyph")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Caption = "Cập Nhập Dữ Liệu";
            this.btnCapNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCapNhap.Glyph")));
            this.btnCapNhap.Id = 6;
            this.btnCapNhap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCapNhap.LargeGlyph")));
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCapNhap_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDSMuon);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThem);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSua);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXoa);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCapNhap);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // gcMuonTra
            // 
            this.gcMuonTra.DataMember = "sp_DSMuonTra";
            this.gcMuonTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcMuonTra.Location = new System.Drawing.Point(0, 128);
            this.gcMuonTra.MainView = this.gvMuonTra;
            this.gcMuonTra.MenuManager = this.ribbonControl1;
            this.gcMuonTra.Name = "gcMuonTra";
            this.gcMuonTra.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gcMuonTra.Size = new System.Drawing.Size(1088, 333);
            this.gcMuonTra.TabIndex = 1;
            this.gcMuonTra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMuonTra});
            // 
            // gvMuonTra
            // 
            this.gvMuonTra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaMuonTra,
            this.colTenDS,
            this.colMaSach,
            this.colMaDG,
            this.colTenDG,
            this.colNgayMuon,
            this.colHanTra,
            this.colNgayTra,
            this.colGhiChu,
            this.colTinhTrangMuon,
            this.colMaNV});
            this.gvMuonTra.GridControl = this.gcMuonTra;
            this.gvMuonTra.Name = "gvMuonTra";
            this.gvMuonTra.OptionsFind.AlwaysVisible = true;
            this.gvMuonTra.OptionsView.ShowGroupPanel = false;
            // 
            // colMaMuonTra
            // 
            this.colMaMuonTra.Caption = "Mã Mượn Trả";
            this.colMaMuonTra.FieldName = "MaMuonTra";
            this.colMaMuonTra.Name = "colMaMuonTra";
            this.colMaMuonTra.OptionsColumn.ReadOnly = true;
            this.colMaMuonTra.Visible = true;
            this.colMaMuonTra.VisibleIndex = 0;
            this.colMaMuonTra.Width = 97;
            // 
            // colTenDS
            // 
            this.colTenDS.Caption = "Tên Đầu Sách";
            this.colTenDS.ColumnEdit = this.repositoryItemComboBox1;
            this.colTenDS.FieldName = "TenDS";
            this.colTenDS.Name = "colTenDS";
            this.colTenDS.OptionsColumn.ReadOnly = true;
            this.colTenDS.Visible = true;
            this.colTenDS.VisibleIndex = 1;
            this.colTenDS.Width = 152;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colMaSach
            // 
            this.colMaSach.Caption = "Mã Sách";
            this.colMaSach.FieldName = "MaSach";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.OptionsColumn.ReadOnly = true;
            this.colMaSach.Visible = true;
            this.colMaSach.VisibleIndex = 2;
            this.colMaSach.Width = 74;
            // 
            // colMaDG
            // 
            this.colMaDG.Caption = "Mã Độc Giả";
            this.colMaDG.FieldName = "MaDG";
            this.colMaDG.Name = "colMaDG";
            this.colMaDG.OptionsColumn.ReadOnly = true;
            this.colMaDG.Visible = true;
            this.colMaDG.VisibleIndex = 3;
            this.colMaDG.Width = 72;
            // 
            // colTenDG
            // 
            this.colTenDG.Caption = "Tên Độc Giả";
            this.colTenDG.FieldName = "TenDG";
            this.colTenDG.Name = "colTenDG";
            this.colTenDG.OptionsColumn.ReadOnly = true;
            this.colTenDG.Visible = true;
            this.colTenDG.VisibleIndex = 4;
            this.colTenDG.Width = 111;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.Caption = "Ngày Mượn";
            this.colNgayMuon.FieldName = "NgayMuon";
            this.colNgayMuon.Name = "colNgayMuon";
            this.colNgayMuon.Visible = true;
            this.colNgayMuon.VisibleIndex = 5;
            this.colNgayMuon.Width = 72;
            // 
            // colHanTra
            // 
            this.colHanTra.Caption = "Hạn Trả";
            this.colHanTra.FieldName = "HanTra";
            this.colHanTra.Name = "colHanTra";
            this.colHanTra.Visible = true;
            this.colHanTra.VisibleIndex = 6;
            this.colHanTra.Width = 78;
            // 
            // colNgayTra
            // 
            this.colNgayTra.Caption = "Ngày Trả";
            this.colNgayTra.FieldName = "NgayTra";
            this.colNgayTra.Name = "colNgayTra";
            this.colNgayTra.Visible = true;
            this.colNgayTra.VisibleIndex = 7;
            this.colNgayTra.Width = 62;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 8;
            this.colGhiChu.Width = 101;
            // 
            // colTinhTrangMuon
            // 
            this.colTinhTrangMuon.Caption = "Tình Trạng Mượn";
            this.colTinhTrangMuon.FieldName = "TinhTrang";
            this.colTinhTrangMuon.Name = "colTinhTrangMuon";
            this.colTinhTrangMuon.Visible = true;
            this.colTinhTrangMuon.VisibleIndex = 9;
            this.colTinhTrangMuon.Width = 109;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Mã Nhân Viên";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.OptionsColumn.ReadOnly = true;
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 10;
            this.colMaNV.Width = 142;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 75);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1088, 53);
            this.groupControl1.TabIndex = 20;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.chkTenDG);
            this.panelControl2.Controls.Add(this.chkMaNV);
            this.panelControl2.Controls.Add(this.chkMaDG);
            this.panelControl2.Controls.Add(this.chkTenDauSach);
            this.panelControl2.Controls.Add(this.chkMaMT);
            this.panelControl2.Controls.Add(this.chkTatCa);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 21);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1084, 30);
            this.panelControl2.TabIndex = 19;
            // 
            // chkTenDG
            // 
            this.chkTenDG.AutoSize = true;
            this.chkTenDG.Location = new System.Drawing.Point(347, 9);
            this.chkTenDG.Name = "chkTenDG";
            this.chkTenDG.Size = new System.Drawing.Size(84, 17);
            this.chkTenDG.TabIndex = 5;
            this.chkTenDG.Text = "Tên Độc Giả";
            this.chkTenDG.UseVisualStyleBackColor = true;
            // 
            // chkMaNV
            // 
            this.chkMaNV.AutoSize = true;
            this.chkMaNV.Location = new System.Drawing.Point(437, 8);
            this.chkMaNV.Name = "chkMaNV";
            this.chkMaNV.Size = new System.Drawing.Size(91, 17);
            this.chkMaNV.TabIndex = 4;
            this.chkMaNV.Text = "Mã Nhân Viên";
            this.chkMaNV.UseVisualStyleBackColor = true;
            // 
            // chkMaDG
            // 
            this.chkMaDG.AutoSize = true;
            this.chkMaDG.Location = new System.Drawing.Point(259, 9);
            this.chkMaDG.Name = "chkMaDG";
            this.chkMaDG.Size = new System.Drawing.Size(80, 17);
            this.chkMaDG.TabIndex = 3;
            this.chkMaDG.Text = "Mã Độc Giả";
            this.chkMaDG.UseVisualStyleBackColor = true;
            // 
            // chkTenDauSach
            // 
            this.chkTenDauSach.AutoSize = true;
            this.chkTenDauSach.Location = new System.Drawing.Point(160, 9);
            this.chkTenDauSach.Name = "chkTenDauSach";
            this.chkTenDauSach.Size = new System.Drawing.Size(93, 17);
            this.chkTenDauSach.TabIndex = 2;
            this.chkTenDauSach.Text = "Tên Đầu Sách";
            this.chkTenDauSach.UseVisualStyleBackColor = true;
            // 
            // chkMaMT
            // 
            this.chkMaMT.AutoSize = true;
            this.chkMaMT.Location = new System.Drawing.Point(68, 9);
            this.chkMaMT.Name = "chkMaMT";
            this.chkMaMT.Size = new System.Drawing.Size(89, 17);
            this.chkMaMT.TabIndex = 1;
            this.chkMaMT.Text = "Mã Đầu Sách";
            this.chkMaMT.UseVisualStyleBackColor = true;
            // 
            // chkTatCa
            // 
            this.chkTatCa.AutoSize = true;
            this.chkTatCa.Location = new System.Drawing.Point(6, 9);
            this.chkTatCa.Name = "chkTatCa";
            this.chkTatCa.Size = new System.Drawing.Size(56, 17);
            this.chkTatCa.TabIndex = 0;
            this.chkTatCa.Text = "Tất cả";
            this.chkTatCa.UseVisualStyleBackColor = true;
            // 
            // frmMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 461);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcMuonTra);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMuonTra";
            this.Text = "frmMuonTra";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMuonTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMuonTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MTbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDSMuon;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnCapNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.GridControl gcMuonTra;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMuonTra;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMuonTra;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDS;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDG;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDG;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayMuon;
        private DevExpress.XtraGrid.Columns.GridColumn colHanTra;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTra;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrangMuon;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.BindingSource MTbindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.CheckBox chkTenDG;
        private System.Windows.Forms.CheckBox chkMaNV;
        private System.Windows.Forms.CheckBox chkMaDG;
        private System.Windows.Forms.CheckBox chkTenDauSach;
        private System.Windows.Forms.CheckBox chkMaMT;
        private System.Windows.Forms.CheckBox chkTatCa;
    }
}