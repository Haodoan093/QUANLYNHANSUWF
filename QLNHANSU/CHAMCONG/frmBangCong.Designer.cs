
namespace QLNHANSU.CHAMCONG
{
    partial class frmBangCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangCong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemBangCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongCV = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkKhoa = new System.Windows.Forms.CheckBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nam = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSachCV = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachCV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKYCONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAMM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYTINHCONGG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYCONGTRONGTHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MACTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCV)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemCV,
            this.btnSuaCV,
            this.btnXoaCV,
            this.btnLuuCV,
            this.btnHuyCV,
            this.btnDongCV,
            this.btnPrintCV,
            this.btnXemBangCong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXemBangCong),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrintCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDongCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemCV
            // 
            this.btnThemCV.Caption = "Thêm";
            this.btnThemCV.Id = 0;
            this.btnThemCV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCV.ImageOptions.Image")));
            this.btnThemCV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemCV.ImageOptions.LargeImage")));
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemCV_ItemClick);
            // 
            // btnSuaCV
            // 
            this.btnSuaCV.Caption = "Sửa";
            this.btnSuaCV.Id = 1;
            this.btnSuaCV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaCV.ImageOptions.Image")));
            this.btnSuaCV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaCV.ImageOptions.LargeImage")));
            this.btnSuaCV.Name = "btnSuaCV";
            this.btnSuaCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaCV_ItemClick);
            // 
            // btnXoaCV
            // 
            this.btnXoaCV.Caption = "Xóa";
            this.btnXoaCV.Id = 2;
            this.btnXoaCV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCV.ImageOptions.Image")));
            this.btnXoaCV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaCV.ImageOptions.LargeImage")));
            this.btnXoaCV.Name = "btnXoaCV";
            this.btnXoaCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaCV_ItemClick);
            // 
            // btnLuuCV
            // 
            this.btnLuuCV.Caption = "Lưu";
            this.btnLuuCV.Id = 3;
            this.btnLuuCV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuCV.ImageOptions.Image")));
            this.btnLuuCV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuuCV.ImageOptions.LargeImage")));
            this.btnLuuCV.Name = "btnLuuCV";
            this.btnLuuCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuCV_ItemClick);
            // 
            // btnHuyCV
            // 
            this.btnHuyCV.Caption = "Hủy";
            this.btnHuyCV.Id = 4;
            this.btnHuyCV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyCV.ImageOptions.Image")));
            this.btnHuyCV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuyCV.ImageOptions.LargeImage")));
            this.btnHuyCV.Name = "btnHuyCV";
            this.btnHuyCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyCV_ItemClick);
            // 
            // btnXemBangCong
            // 
            this.btnXemBangCong.Caption = "Xem Bảng Công ";
            this.btnXemBangCong.Id = 7;
            this.btnXemBangCong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXemBangCong.ImageOptions.SvgImage")));
            this.btnXemBangCong.Name = "btnXemBangCong";
            this.btnXemBangCong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXemBangCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemBangCong_ItemClick);
            // 
            // btnPrintCV
            // 
            this.btnPrintCV.Caption = "In";
            this.btnPrintCV.Id = 6;
            this.btnPrintCV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintCV.ImageOptions.Image")));
            this.btnPrintCV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrintCV.ImageOptions.LargeImage")));
            this.btnPrintCV.Name = "btnPrintCV";
            this.btnPrintCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintCV_ItemClick);
            // 
            // btnDongCV
            // 
            this.btnDongCV.Caption = "Đóng";
            this.btnDongCV.Id = 5;
            this.btnDongCV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongCV.ImageOptions.Image")));
            this.btnDongCV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDongCV.ImageOptions.LargeImage")));
            this.btnDongCV.Name = "btnDongCV";
            this.btnDongCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDongCV_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1030, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 609);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1030, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 579);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1030, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 579);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkKhoa);
            this.splitContainer1.Panel1.Controls.Add(this.chkTrangThai);
            this.splitContainer1.Panel1.Controls.Add(this.cboThang);
            this.splitContainer1.Panel1.Controls.Add(this.cboNam);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.nam);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSachCV);
            this.splitContainer1.Size = new System.Drawing.Size(1030, 579);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.TabIndex = 16;
            // 
            // chkKhoa
            // 
            this.chkKhoa.AutoSize = true;
            this.chkKhoa.Location = new System.Drawing.Point(556, 84);
            this.chkKhoa.Name = "chkKhoa";
            this.chkKhoa.Size = new System.Drawing.Size(61, 21);
            this.chkKhoa.TabIndex = 9;
            this.chkKhoa.Text = "Khóa";
            this.chkKhoa.UseVisualStyleBackColor = true;
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Location = new System.Drawing.Point(556, 40);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(95, 21);
            this.chkTrangThai.TabIndex = 8;
            this.chkTrangThai.Text = "Trạng Thái";
            this.chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(244, 82);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(121, 24);
            this.cboThang.TabIndex = 6;
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cboNam.Location = new System.Drawing.Point(244, 37);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(121, 24);
            this.cboNam.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(178, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tháng";
            // 
            // nam
            // 
            this.nam.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam.Appearance.Options.UseFont = true;
            this.nam.Location = new System.Drawing.Point(190, 36);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(34, 21);
            this.nam.TabIndex = 0;
            this.nam.Text = "Năm";
            // 
            // gcDanhSachCV
            // 
            this.gcDanhSachCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSachCV.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSachCV.MainView = this.gvDanhSachCV;
            this.gcDanhSachCV.MenuManager = this.barManager1;
            this.gcDanhSachCV.Name = "gcDanhSachCV";
            this.gcDanhSachCV.Size = new System.Drawing.Size(1030, 444);
            this.gcDanhSachCV.TabIndex = 0;
            this.gcDanhSachCV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachCV});
            // 
            // gvDanhSachCV
            // 
            this.gvDanhSachCV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DELETED_BY,
            this.MAKYCONG,
            this.THANG,
            this.NAMM,
            this.KHOA,
            this.NGAYTINHCONGG,
            this.NGAYCONGTRONGTHANG,
            this.MACTY,
            this.TRANGTHAI});
            this.gvDanhSachCV.GridControl = this.gcDanhSachCV;
            this.gvDanhSachCV.Name = "gvDanhSachCV";
            this.gvDanhSachCV.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSachCV_CustomDrawCell);
            this.gvDanhSachCV.Click += new System.EventHandler(this.gvDanhSachCV_Click);
            // 
            // DELETED_BY
            // 
            this.DELETED_BY.FieldName = "DELETED_BY";
            this.DELETED_BY.MaxWidth = 80;
            this.DELETED_BY.MinWidth = 25;
            this.DELETED_BY.Name = "DELETED_BY";
            this.DELETED_BY.Visible = true;
            this.DELETED_BY.VisibleIndex = 0;
            this.DELETED_BY.Width = 28;
            // 
            // MAKYCONG
            // 
            this.MAKYCONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MAKYCONG.AppearanceHeader.Options.UseFont = true;
            this.MAKYCONG.Caption = "MÃ KỲ CÔNG";
            this.MAKYCONG.FieldName = "MAKYCONG";
            this.MAKYCONG.MaxWidth = 110;
            this.MAKYCONG.MinWidth = 110;
            this.MAKYCONG.Name = "MAKYCONG";
            this.MAKYCONG.Visible = true;
            this.MAKYCONG.VisibleIndex = 1;
            this.MAKYCONG.Width = 110;
            // 
            // THANG
            // 
            this.THANG.Caption = "THÁNG";
            this.THANG.FieldName = "THANG";
            this.THANG.MaxWidth = 80;
            this.THANG.MinWidth = 80;
            this.THANG.Name = "THANG";
            this.THANG.Visible = true;
            this.THANG.VisibleIndex = 2;
            this.THANG.Width = 80;
            // 
            // NAMM
            // 
            this.NAMM.Caption = "Năm";
            this.NAMM.FieldName = "NAM";
            this.NAMM.MaxWidth = 100;
            this.NAMM.MinWidth = 80;
            this.NAMM.Name = "NAMM";
            this.NAMM.Visible = true;
            this.NAMM.VisibleIndex = 3;
            this.NAMM.Width = 100;
            // 
            // KHOA
            // 
            this.KHOA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.KHOA.AppearanceHeader.Options.UseFont = true;
            this.KHOA.Caption = "KHÓA";
            this.KHOA.FieldName = "KHOA";
            this.KHOA.MaxWidth = 80;
            this.KHOA.MinWidth = 80;
            this.KHOA.Name = "KHOA";
            this.KHOA.Visible = true;
            this.KHOA.VisibleIndex = 4;
            this.KHOA.Width = 80;
            // 
            // NGAYTINHCONGG
            // 
            this.NGAYTINHCONGG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NGAYTINHCONGG.AppearanceHeader.Options.UseFont = true;
            this.NGAYTINHCONGG.Caption = "NGÀY TÍNH CÔNG";
            this.NGAYTINHCONGG.FieldName = "NGAYTINHCONG";
            this.NGAYTINHCONGG.MaxWidth = 120;
            this.NGAYTINHCONGG.MinWidth = 120;
            this.NGAYTINHCONGG.Name = "NGAYTINHCONGG";
            this.NGAYTINHCONGG.Visible = true;
            this.NGAYTINHCONGG.VisibleIndex = 5;
            this.NGAYTINHCONGG.Width = 120;
            // 
            // NGAYCONGTRONGTHANG
            // 
            this.NGAYCONGTRONGTHANG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NGAYCONGTRONGTHANG.AppearanceHeader.Options.UseFont = true;
            this.NGAYCONGTRONGTHANG.Caption = "NGÀY CÔNG";
            this.NGAYCONGTRONGTHANG.FieldName = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.MaxWidth = 100;
            this.NGAYCONGTRONGTHANG.MinWidth = 100;
            this.NGAYCONGTRONGTHANG.Name = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.Visible = true;
            this.NGAYCONGTRONGTHANG.VisibleIndex = 6;
            this.NGAYCONGTRONGTHANG.Width = 100;
            // 
            // MACTY
            // 
            this.MACTY.Caption = "MÃ CTY";
            this.MACTY.FieldName = "MACTY";
            this.MACTY.MinWidth = 25;
            this.MACTY.Name = "MACTY";
            this.MACTY.Width = 94;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TRANGTHAI.AppearanceHeader.Options.UseFont = true;
            this.TRANGTHAI.Caption = "TRẠNG THÁI";
            this.TRANGTHAI.FieldName = "TRANGTHAI";
            this.TRANGTHAI.MaxWidth = 100;
            this.TRANGTHAI.MinWidth = 100;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = true;
            this.TRANGTHAI.VisibleIndex = 7;
            this.TRANGTHAI.Width = 100;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl1.Location = new System.Drawing.Point(0, 30);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 579);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl2.Location = new System.Drawing.Point(1030, 30);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(0, 579);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl3.Location = new System.Drawing.Point(0, 609);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(1030, 0);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl4.Location = new System.Drawing.Point(0, 30);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(1030, 0);
            // 
            // frmBangCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 629);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBangCong";
            this.Text = "frmBangCong";
            this.Load += new System.EventHandler(this.frmBangCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemCV;
        private DevExpress.XtraBars.BarButtonItem btnSuaCV;
        private DevExpress.XtraBars.BarButtonItem btnXoaCV;
        private DevExpress.XtraBars.BarButtonItem btnLuuCV;
        private DevExpress.XtraBars.BarButtonItem btnHuyCV;
        private DevExpress.XtraBars.BarButtonItem btnPrintCV;
        private DevExpress.XtraBars.BarButtonItem btnDongCV;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl nam;
        private DevExpress.XtraGrid.GridControl gcDanhSachCV;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachCV;
        private DevExpress.XtraGrid.Columns.GridColumn DELETED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn MAKYCONG;
        private DevExpress.XtraGrid.Columns.GridColumn THANG;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn NAMM;
        private DevExpress.XtraGrid.Columns.GridColumn KHOA;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYTINHCONGG;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCONGTRONGTHANG;
        private DevExpress.XtraGrid.Columns.GridColumn MACTY;
        private DevExpress.XtraGrid.Columns.GridColumn TRANGTHAI;
        private System.Windows.Forms.CheckBox chkKhoa;
        private DevExpress.XtraBars.BarButtonItem btnXemBangCong;
    }
}