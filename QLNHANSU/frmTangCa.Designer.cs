
namespace QLNHANSU
{
    partial class frmTangCa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTangCa));
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DELETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAICA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOGIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDLOAICA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnThemCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongCV = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spSoGio = new DevExpress.XtraEditors.SpinEdit();
            this.cboLoaiCa = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHUCVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSoGio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DELETE,
            this.ID,
            this.HOTENNV,
            this.TENLOAICA,
            this.SOGIO,
            this.HESO,
            this.SOOTIEN,
            this.GHICHU,
            this.IDNV,
            this.IDLOAICA});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSach_CustomDrawCell);
            // 
            // DELETE
            // 
            this.DELETE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.DELETE.AppearanceHeader.Options.UseFont = true;
            this.DELETE.Caption = "DELETE ";
            this.DELETE.FieldName = "DELETED_BY";
            this.DELETE.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DELETE.ImageOptions.SvgImage")));
            this.DELETE.MinWidth = 25;
            this.DELETE.Name = "DELETE";
            this.DELETE.Visible = true;
            this.DELETE.VisibleIndex = 0;
            this.DELETE.Width = 94;
            // 
            // ID
            // 
            this.ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.ID.AppearanceHeader.Options.UseFont = true;
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MaxWidth = 200;
            this.ID.MinWidth = 30;
            this.ID.Name = "ID";
            this.ID.Width = 94;
            // 
            // HOTENNV
            // 
            this.HOTENNV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HOTENNV.AppearanceHeader.Options.UseFont = true;
            this.HOTENNV.Caption = "Họ Tên";
            this.HOTENNV.FieldName = "HOTEN";
            this.HOTENNV.MaxWidth = 200;
            this.HOTENNV.MinWidth = 150;
            this.HOTENNV.Name = "HOTENNV";
            this.HOTENNV.Visible = true;
            this.HOTENNV.VisibleIndex = 1;
            this.HOTENNV.Width = 200;
            // 
            // TENLOAICA
            // 
            this.TENLOAICA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TENLOAICA.AppearanceHeader.Options.UseFont = true;
            this.TENLOAICA.Caption = "LOẠI CA";
            this.TENLOAICA.FieldName = "TENLOAICA";
            this.TENLOAICA.MaxWidth = 100;
            this.TENLOAICA.MinWidth = 80;
            this.TENLOAICA.Name = "TENLOAICA";
            this.TENLOAICA.Visible = true;
            this.TENLOAICA.VisibleIndex = 2;
            this.TENLOAICA.Width = 100;
            // 
            // SOGIO
            // 
            this.SOGIO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SOGIO.AppearanceHeader.Options.UseFont = true;
            this.SOGIO.Caption = "SỐ GIỜ";
            this.SOGIO.FieldName = "SOGIO";
            this.SOGIO.MaxWidth = 100;
            this.SOGIO.MinWidth = 80;
            this.SOGIO.Name = "SOGIO";
            this.SOGIO.Visible = true;
            this.SOGIO.VisibleIndex = 3;
            this.SOGIO.Width = 86;
            // 
            // HESO
            // 
            this.HESO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HESO.AppearanceHeader.Options.UseFont = true;
            this.HESO.Caption = "HỆ SỐ";
            this.HESO.FieldName = "HESO";
            this.HESO.MaxWidth = 120;
            this.HESO.MinWidth = 100;
            this.HESO.Name = "HESO";
            this.HESO.Visible = true;
            this.HESO.VisibleIndex = 4;
            this.HESO.Width = 120;
            // 
            // SOOTIEN
            // 
            this.SOOTIEN.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.SOOTIEN.AppearanceHeader.Options.UseFont = true;
            this.SOOTIEN.Caption = "SỐ TIỀN";
            this.SOOTIEN.FieldName = "SOTIEN";
            this.SOOTIEN.MaxWidth = 120;
            this.SOOTIEN.MinWidth = 100;
            this.SOOTIEN.Name = "SOOTIEN";
            this.SOOTIEN.Visible = true;
            this.SOOTIEN.VisibleIndex = 5;
            this.SOOTIEN.Width = 100;
            // 
            // GHICHU
            // 
            this.GHICHU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.GHICHU.AppearanceHeader.Options.UseFont = true;
            this.GHICHU.Caption = "GHI CHU";
            this.GHICHU.FieldName = "GHICHU";
            this.GHICHU.MaxWidth = 250;
            this.GHICHU.MinWidth = 200;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Visible = true;
            this.GHICHU.VisibleIndex = 6;
            this.GHICHU.Width = 200;
            // 
            // IDNV
            // 
            this.IDNV.Caption = "MANV";
            this.IDNV.FieldName = "MANV";
            this.IDNV.MinWidth = 25;
            this.IDNV.Name = "IDNV";
            this.IDNV.Width = 86;
            // 
            // IDLOAICA
            // 
            this.IDLOAICA.Caption = "IDLC";
            this.IDLOAICA.FieldName = "IDLOAICA";
            this.IDLOAICA.MinWidth = 25;
            this.IDLOAICA.Name = "IDLOAICA";
            this.IDLOAICA.Width = 148;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(994, 408);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            this.gcDanhSach.Click += new System.EventHandler(this.gc_DanhSach_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4,
            this.bar5});
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
            this.btnPrintCV});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar5;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrintCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDongCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
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
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(994, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 568);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(994, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 538);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(994, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 538);
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
            this.splitContainer1.Panel1.Controls.Add(this.txtNoiDung);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.spSoGio);
            this.splitContainer1.Panel1.Controls.Add(this.cboLoaiCa);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.lkNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(994, 538);
            this.splitContainer1.SplitterDistance = 126;
            this.splitContainer1.TabIndex = 9;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(107, 87);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(821, 23);
            this.txtNoiDung.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(25, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 21);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Ghi chú";
            // 
            // spSoGio
            // 
            this.spSoGio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSoGio.Location = new System.Drawing.Point(771, 32);
            this.spSoGio.MenuManager = this.barManager1;
            this.spSoGio.Name = "spSoGio";
            this.spSoGio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSoGio.Size = new System.Drawing.Size(157, 24);
            this.spSoGio.TabIndex = 7;
            // 
            // cboLoaiCa
            // 
            this.cboLoaiCa.FormattingEnabled = true;
            this.cboLoaiCa.Location = new System.Drawing.Point(518, 32);
            this.cboLoaiCa.Name = "cboLoaiCa";
            this.cboLoaiCa.Size = new System.Drawing.Size(121, 24);
            this.cboLoaiCa.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(698, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 21);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Số Giờ";
            // 
            // lkNhanVien
            // 
            this.lkNhanVien.Location = new System.Drawing.Point(107, 33);
            this.lkNhanVien.MenuManager = this.barManager1;
            this.lkNhanVien.Name = "lkNhanVien";
            this.lkNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNhanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.lkNhanVien.Size = new System.Drawing.Size(251, 22);
            this.lkNhanVien.TabIndex = 4;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MANV,
            this.HOTEN,
            this.CHUCVU});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MANV
            // 
            this.MANV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MANV.AppearanceHeader.Options.UseFont = true;
            this.MANV.Caption = "ID";
            this.MANV.FieldName = "MANV";
            this.MANV.MaxWidth = 70;
            this.MANV.MinWidth = 70;
            this.MANV.Name = "MANV";
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 0;
            this.MANV.Width = 70;
            // 
            // HOTEN
            // 
            this.HOTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HOTEN.AppearanceHeader.Options.UseFont = true;
            this.HOTEN.Caption = "Ho Ten";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 250;
            this.HOTEN.MinWidth = 150;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 150;
            // 
            // CHUCVU
            // 
            this.CHUCVU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.CHUCVU.AppearanceHeader.Options.UseFont = true;
            this.CHUCVU.Caption = "CHỨC VỤ";
            this.CHUCVU.FieldName = "IDCV";
            this.CHUCVU.MaxWidth = 120;
            this.CHUCVU.MinWidth = 80;
            this.CHUCVU.Name = "CHUCVU";
            this.CHUCVU.Visible = true;
            this.CHUCVU.VisibleIndex = 2;
            this.CHUCVU.Width = 80;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(434, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Loại Ca";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhân viên";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // frmTangCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 588);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTangCa";
            this.Text = "frmTangCa";
            this.Load += new System.EventHandler(this.frmTangCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spSoGio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn HOTENNV;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAICA;
        private DevExpress.XtraGrid.Columns.GridColumn SOGIO;
        private DevExpress.XtraGrid.Columns.GridColumn HESO;
        private DevExpress.XtraGrid.Columns.GridColumn IDNV;
        private DevExpress.XtraGrid.Columns.GridColumn IDLOAICA;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnThemCV;
        private DevExpress.XtraBars.BarButtonItem btnSuaCV;
        private DevExpress.XtraBars.BarButtonItem btnXoaCV;
        private DevExpress.XtraBars.BarButtonItem btnLuuCV;
        private DevExpress.XtraBars.BarButtonItem btnHuyCV;
        private DevExpress.XtraBars.BarButtonItem btnPrintCV;
        private DevExpress.XtraBars.BarButtonItem btnDongCV;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtNoiDung;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit spSoGio;
        private System.Windows.Forms.ComboBox cboLoaiCa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit lkNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn CHUCVU;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraGrid.Columns.GridColumn SOOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn DELETE;
        private DevExpress.XtraGrid.Columns.GridColumn GHICHU;
    }
}