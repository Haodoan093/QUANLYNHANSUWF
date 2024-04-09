
namespace QLNHANSU
{
    partial class frmLoaiCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiCong));
            this.HESO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvDanhSachCV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LOAICA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSachCV = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongCV = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenCV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spHeSo = new DevExpress.XtraEditors.SpinEdit();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HESO
            // 
            this.HESO.Caption = "Hệ số";
            this.HESO.FieldName = "HESO";
            this.HESO.MinWidth = 25;
            this.HESO.Name = "HESO";
            this.HESO.Visible = true;
            this.HESO.VisibleIndex = 3;
            this.HESO.Width = 94;
            // 
            // ID
            // 
            this.ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.ID.AppearanceHeader.Options.UseFont = true;
            this.ID.Caption = "ID";
            this.ID.FieldName = "IDLC";
            this.ID.MaxWidth = 200;
            this.ID.MinWidth = 30;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 1;
            this.ID.Width = 94;
            // 
            // DELETED_BY
            // 
            this.DELETED_BY.FieldName = "DELETED_BY";
            this.DELETED_BY.MinWidth = 25;
            this.DELETED_BY.Name = "DELETED_BY";
            this.DELETED_BY.Visible = true;
            this.DELETED_BY.VisibleIndex = 0;
            this.DELETED_BY.Width = 94;
            // 
            // gvDanhSachCV
            // 
            this.gvDanhSachCV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DELETED_BY,
            this.ID,
            this.LOAICA,
            this.HESO});
            this.gvDanhSachCV.GridControl = this.gcDanhSachCV;
            this.gvDanhSachCV.Name = "gvDanhSachCV";
            this.gvDanhSachCV.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSachCV_CustomDrawCell);
            this.gvDanhSachCV.Click += new System.EventHandler(this.gvDanhSachCV_Click);
            // 
            // LOAICA
            // 
            this.LOAICA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.LOAICA.AppearanceHeader.Options.UseFont = true;
            this.LOAICA.Caption = "Loại ca";
            this.LOAICA.FieldName = "TENLC";
            this.LOAICA.MaxWidth = 400;
            this.LOAICA.MinWidth = 300;
            this.LOAICA.Name = "LOAICA";
            this.LOAICA.Visible = true;
            this.LOAICA.VisibleIndex = 2;
            this.LOAICA.Width = 300;
            // 
            // gcDanhSachCV
            // 
            this.gcDanhSachCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSachCV.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSachCV.MainView = this.gvDanhSachCV;
            this.gcDanhSachCV.MenuManager = this.barManager1;
            this.gcDanhSachCV.Name = "gcDanhSachCV";
            this.gcDanhSachCV.Size = new System.Drawing.Size(1101, 533);
            this.gcDanhSachCV.TabIndex = 0;
            this.gcDanhSachCV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachCV});
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
            this.btnPrintCV});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1101, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 733);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1101, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 703);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1101, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 703);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(69, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Hệ số";
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(145, 20);
            this.txtTenCV.MenuManager = this.barManager1;
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(157, 22);
            this.txtTenCV.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(69, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Loại công";
            // 
            // spHeSo
            // 
            this.spHeSo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spHeSo.Location = new System.Drawing.Point(145, 65);
            this.spHeSo.MenuManager = this.barManager1;
            this.spHeSo.Name = "spHeSo";
            this.spHeSo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHeSo.Size = new System.Drawing.Size(157, 24);
            this.spHeSo.TabIndex = 3;
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
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.spHeSo);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenCV);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSachCV);
            this.splitContainer1.Size = new System.Drawing.Size(1101, 703);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(546, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "labelControl3";
            // 
            // frmLoaiCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 753);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLoaiCong";
            this.Text = "Loại công";
            this.Load += new System.EventHandler(this.frmLoaiCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSo.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn HESO;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn DELETED_BY;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachCV;
        private DevExpress.XtraGrid.Columns.GridColumn LOAICA;
        private DevExpress.XtraGrid.GridControl gcDanhSachCV;
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
        private DevExpress.XtraEditors.SpinEdit spHeSo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenCV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}