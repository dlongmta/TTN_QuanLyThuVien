namespace BTL_QUANLYTHUVIEN
{
    partial class frmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            this.nbcThongTin = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgDSDauSach = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.gcDauSach = new DevExpress.XtraGrid.GridControl();
            this.gvDauSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTheLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chkTacGia = new System.Windows.Forms.CheckBox();
            this.chkTheLoai = new System.Windows.Forms.CheckBox();
            this.chkTenDauSach = new System.Windows.Forms.CheckBox();
            this.chkMaDauSach = new System.Windows.Forms.CheckBox();
            this.chkTatCa = new System.Windows.Forms.CheckBox();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnMuonSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraSach = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DSbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nbcDS = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgThongTin = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer2 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbTenDS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gcSach = new DevExpress.XtraGrid.GridControl();
            this.gvSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrangMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.nbcThongTin)).BeginInit();
            this.nbcThongTin.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDauSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDauSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbcDS)).BeginInit();
            this.nbcDS.SuspendLayout();
            this.navBarGroupControlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // nbcThongTin
            // 
            this.nbcThongTin.ActiveGroup = this.nbgDSDauSach;
            this.nbcThongTin.Controls.Add(this.navBarGroupControlContainer1);
            this.nbcThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.nbcThongTin.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgDSDauSach});
            this.nbcThongTin.Location = new System.Drawing.Point(0, 0);
            this.nbcThongTin.Name = "nbcThongTin";
            this.nbcThongTin.OptionsNavPane.ExpandedWidth = 500;
            this.nbcThongTin.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.nbcThongTin.Size = new System.Drawing.Size(500, 461);
            this.nbcThongTin.TabIndex = 1;
            this.nbcThongTin.Text = "Thông Tin Đầu Sách";
            // 
            // nbgDSDauSach
            // 
            this.nbgDSDauSach.Caption = "Danh sách Đầu Sách";
            this.nbgDSDauSach.ControlContainer = this.navBarGroupControlContainer1;
            this.nbgDSDauSach.Expanded = true;
            this.nbgDSDauSach.GroupClientHeight = 358;
            this.nbgDSDauSach.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.nbgDSDauSach.Name = "nbgDSDauSach";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.gcDauSach);
            this.navBarGroupControlContainer1.Controls.Add(this.groupControl2);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(500, 358);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // gcDauSach
            // 
            this.gcDauSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDauSach.Location = new System.Drawing.Point(0, 50);
            this.gcDauSach.MainView = this.gvDauSach;
            this.gcDauSach.Name = "gcDauSach";
            this.gcDauSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gcDauSach.Size = new System.Drawing.Size(500, 308);
            this.gcDauSach.TabIndex = 22;
            this.gcDauSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDauSach});
            // 
            // gvDauSach
            // 
            this.gvDauSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDS,
            this.colTenDS,
            this.colTheLoai,
            this.colTacGia,
            this.colNXB,
            this.colSL,
            this.colGiaSach});
            this.gvDauSach.GridControl = this.gcDauSach;
            this.gvDauSach.Name = "gvDauSach";
            this.gvDauSach.OptionsFind.AlwaysVisible = true;
            this.gvDauSach.OptionsView.ShowGroupPanel = false;
            this.gvDauSach.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDauSach_FocusedRowChanged);
            // 
            // colMaDS
            // 
            this.colMaDS.Caption = "Mã Đầu Sách";
            this.colMaDS.FieldName = "MaDS";
            this.colMaDS.Name = "colMaDS";
            this.colMaDS.OptionsColumn.ReadOnly = true;
            this.colMaDS.Visible = true;
            this.colMaDS.VisibleIndex = 0;
            this.colMaDS.Width = 84;
            // 
            // colTenDS
            // 
            this.colTenDS.Caption = "Tên Đầu Sách";
            this.colTenDS.FieldName = "TenDS";
            this.colTenDS.Name = "colTenDS";
            this.colTenDS.OptionsColumn.ReadOnly = true;
            this.colTenDS.Visible = true;
            this.colTenDS.VisibleIndex = 1;
            this.colTenDS.Width = 109;
            // 
            // colTheLoai
            // 
            this.colTheLoai.Caption = "Thể Loại";
            this.colTheLoai.ColumnEdit = this.repositoryItemComboBox1;
            this.colTheLoai.FieldName = "TenTL";
            this.colTheLoai.Name = "colTheLoai";
            this.colTheLoai.OptionsColumn.ReadOnly = true;
            this.colTheLoai.Visible = true;
            this.colTheLoai.VisibleIndex = 2;
            this.colTheLoai.Width = 109;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colTacGia
            // 
            this.colTacGia.Caption = "Tác Giả";
            this.colTacGia.FieldName = "TenTG";
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.OptionsColumn.ReadOnly = true;
            this.colTacGia.Width = 109;
            // 
            // colNXB
            // 
            this.colNXB.Caption = "Nhà Xuất Bản";
            this.colNXB.FieldName = "NXB";
            this.colNXB.Name = "colNXB";
            this.colNXB.OptionsColumn.ReadOnly = true;
            this.colNXB.Width = 109;
            // 
            // colSL
            // 
            this.colSL.Caption = "Số Lượng";
            this.colSL.FieldName = "SoLuong";
            this.colSL.Name = "colSL";
            this.colSL.OptionsColumn.ReadOnly = true;
            this.colSL.Visible = true;
            this.colSL.VisibleIndex = 3;
            this.colSL.Width = 109;
            // 
            // colGiaSach
            // 
            this.colGiaSach.Caption = "Giá Sách";
            this.colGiaSach.FieldName = "GiaSach";
            this.colGiaSach.Name = "colGiaSach";
            this.colGiaSach.OptionsColumn.ReadOnly = true;
            this.colGiaSach.Width = 116;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(500, 50);
            this.groupControl2.TabIndex = 21;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chkTacGia);
            this.panelControl1.Controls.Add(this.chkTheLoai);
            this.panelControl1.Controls.Add(this.chkTenDauSach);
            this.panelControl1.Controls.Add(this.chkMaDauSach);
            this.panelControl1.Controls.Add(this.chkTatCa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(496, 27);
            this.panelControl1.TabIndex = 19;
            // 
            // chkTacGia
            // 
            this.chkTacGia.AutoSize = true;
            this.chkTacGia.Location = new System.Drawing.Point(347, 9);
            this.chkTacGia.Name = "chkTacGia";
            this.chkTacGia.Size = new System.Drawing.Size(61, 17);
            this.chkTacGia.TabIndex = 5;
            this.chkTacGia.Text = "Tác Giả";
            this.chkTacGia.UseVisualStyleBackColor = true;
            // 
            // chkTheLoai
            // 
            this.chkTheLoai.AutoSize = true;
            this.chkTheLoai.Location = new System.Drawing.Point(259, 9);
            this.chkTheLoai.Name = "chkTheLoai";
            this.chkTheLoai.Size = new System.Drawing.Size(66, 17);
            this.chkTheLoai.TabIndex = 3;
            this.chkTheLoai.Text = "Thể Loại";
            this.chkTheLoai.UseVisualStyleBackColor = true;
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
            // chkMaDauSach
            // 
            this.chkMaDauSach.AutoSize = true;
            this.chkMaDauSach.Location = new System.Drawing.Point(68, 9);
            this.chkMaDauSach.Name = "chkMaDauSach";
            this.chkMaDauSach.Size = new System.Drawing.Size(89, 17);
            this.chkMaDauSach.TabIndex = 1;
            this.chkMaDauSach.Text = "Mã Đầu Sách";
            this.chkMaDauSach.UseVisualStyleBackColor = true;
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThem);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXoa);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMuonSach);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTraSach);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "\r\nDanh sách Đầu Sách";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 4;
            this.btnXoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.LargeGlyph")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnMuonSach
            // 
            this.btnMuonSach.Caption = "Mượn Sách";
            this.btnMuonSach.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMuonSach.Glyph")));
            this.btnMuonSach.Id = 9;
            this.btnMuonSach.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMuonSach.LargeGlyph")));
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMuonSach_ItemClick);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Caption = "Trả Sách";
            this.btnTraSach.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTraSach.Glyph")));
            this.btnTraSach.Id = 10;
            this.btnTraSach.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTraSach.LargeGlyph")));
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraSach_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.DrawGroupsBorder = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnThem,
            this.btnXoa,
            this.barButtonItem1,
            this.btnMuonSach,
            this.btnTraSach,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(500, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(588, 75);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // nbcDS
            // 
            this.nbcDS.ActiveGroup = this.nbgThongTin;
            this.nbcDS.Controls.Add(this.navBarGroupControlContainer2);
            this.nbcDS.Dock = System.Windows.Forms.DockStyle.Left;
            this.nbcDS.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgThongTin});
            this.nbcDS.Location = new System.Drawing.Point(500, 75);
            this.nbcDS.Name = "nbcDS";
            this.nbcDS.OptionsNavPane.ExpandedWidth = 237;
            this.nbcDS.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed;
            this.nbcDS.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.nbcDS.Size = new System.Drawing.Size(37, 386);
            this.nbcDS.TabIndex = 8;
            this.nbcDS.Text = "Thông Tin Đầu Sách";
            // 
            // nbgThongTin
            // 
            this.nbgThongTin.Caption = "Thông Tin Đầu Sách";
            this.nbgThongTin.ControlContainer = this.navBarGroupControlContainer2;
            this.nbgThongTin.Expanded = true;
            this.nbgThongTin.GroupClientHeight = 283;
            this.nbgThongTin.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.nbgThongTin.Name = "nbgThongTin";
            // 
            // navBarGroupControlContainer2
            // 
            this.navBarGroupControlContainer2.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer2.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer2.Controls.Add(this.panelControl2);
            this.navBarGroupControlContainer2.Name = "navBarGroupControlContainer2";
            this.navBarGroupControlContainer2.Size = new System.Drawing.Size(237, 283);
            this.navBarGroupControlContainer2.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnLuu);
            this.panelControl2.Controls.Add(this.btnHuy);
            this.panelControl2.Controls.Add(this.tbSoLuong);
            this.panelControl2.Controls.Add(this.tbTenDS);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Location = new System.Drawing.Point(6, 44);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(215, 181);
            this.panelControl2.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnLuu.Location = new System.Drawing.Point(13, 143);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 33;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnHuy.Location = new System.Drawing.Point(118, 143);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(106, 95);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(87, 21);
            this.tbSoLuong.TabIndex = 9;
            this.tbSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoLuong_KeyPress);
            // 
            // tbTenDS
            // 
            this.tbTenDS.Location = new System.Drawing.Point(13, 46);
            this.tbTenDS.Name = "tbTenDS";
            this.tbTenDS.ReadOnly = true;
            this.tbTenDS.Size = new System.Drawing.Size(180, 21);
            this.tbTenDS.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Đầu Sách";
            // 
            // gcSach
            // 
            this.gcSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSach.Location = new System.Drawing.Point(537, 75);
            this.gcSach.MainView = this.gvSach;
            this.gcSach.Name = "gcSach";
            this.gcSach.Size = new System.Drawing.Size(551, 386);
            this.gcSach.TabIndex = 10;
            this.gcSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSach});
            // 
            // gvSach
            // 
            this.gvSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSach,
            this.colTinhTrang,
            this.colTinhTrangMuon});
            this.gvSach.GridControl = this.gcSach;
            this.gvSach.Name = "gvSach";
            this.gvSach.OptionsFind.AlwaysVisible = true;
            this.gvSach.OptionsView.ShowGroupPanel = false;
            this.gvSach.OptionsView.ShowViewCaption = true;
            this.gvSach.ViewCaption = "Đầu Sách";
            // 
            // colMaSach
            // 
            this.colMaSach.Caption = "Mã Sách";
            this.colMaSach.FieldName = "MaSach";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.OptionsColumn.ReadOnly = true;
            this.colMaSach.Visible = true;
            this.colMaSach.VisibleIndex = 0;
            this.colMaSach.Width = 189;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Caption = "Tình Trạng";
            this.colTinhTrang.FieldName = "TinhTrang";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.OptionsColumn.ReadOnly = true;
            this.colTinhTrang.Visible = true;
            this.colTinhTrang.VisibleIndex = 1;
            this.colTinhTrang.Width = 180;
            // 
            // colTinhTrangMuon
            // 
            this.colTinhTrangMuon.Caption = "Tình Trạng Mượn";
            this.colTinhTrangMuon.FieldName = "TinhTrangMuon";
            this.colTinhTrangMuon.Name = "colTinhTrangMuon";
            this.colTinhTrangMuon.OptionsColumn.ReadOnly = true;
            this.colTinhTrangMuon.Visible = true;
            this.colTinhTrangMuon.VisibleIndex = 2;
            this.colTinhTrangMuon.Width = 157;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Cập Nhập";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 461);
            this.Controls.Add(this.gcSach);
            this.Controls.Add(this.nbcDS);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.nbcThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKho";
            this.Text = "frmKho";
            ((System.ComponentModel.ISupportInitialize)(this.nbcThongTin)).EndInit();
            this.nbcThongTin.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDauSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDauSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbcDS)).EndInit();
            this.nbcDS.ResumeLayout(false);
            this.navBarGroupControlContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl nbcThongTin;
        private DevExpress.XtraNavBar.NavBarGroup nbgDSDauSach;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.CheckBox chkTacGia;
        private System.Windows.Forms.CheckBox chkTheLoai;
        private System.Windows.Forms.CheckBox chkTenDauSach;
        private System.Windows.Forms.CheckBox chkMaDauSach;
        private System.Windows.Forms.CheckBox chkTatCa;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.GridControl gcDauSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDauSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDS;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDS;
        private DevExpress.XtraGrid.Columns.GridColumn colTheLoai;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn colNXB;
        private DevExpress.XtraGrid.Columns.GridColumn colSL;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaSach;
        private System.Windows.Forms.BindingSource DSbindingSource;
        private System.Windows.Forms.BindingSource SbindingSource;
        private DevExpress.XtraNavBar.NavBarControl nbcDS;
        private DevExpress.XtraNavBar.NavBarGroup nbgThongTin;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.TextBox tbTenDS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private DevExpress.XtraGrid.GridControl gcSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSach;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrangMuon;
        private DevExpress.XtraBars.BarButtonItem btnMuonSach;
        private DevExpress.XtraBars.BarButtonItem btnTraSach;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}