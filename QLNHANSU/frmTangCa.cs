using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANSU
{
    public partial class frmTangCa : DevExpress.XtraEditors.XtraForm
    {
        public frmTangCa()
        {
            InitializeComponent();
        }
        TANGCA _tangca;
        NHANVIEN _nhanvien;
        LOAICA _loaica;
        bool _isAdding;
        int _id;
        SYS_CONFIG _config;
        private void frmTangCa_Load(object sender, EventArgs e)
        {
            _isAdding = false;
            _tangca = new TANGCA();
            _loaica = new LOAICA();
            _nhanvien = new NHANVIEN();
            _config = new SYS_CONFIG();
            ShowHideControls(true);
            LoadData();
            loadNhanVien();
            loadLoaiCa();
        }
        void LoadData()
        {
            gcDanhSach.DataSource = _tangca.GetListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadNhanVien()
        {
            lkNhanVien.Properties.DataSource = _nhanvien.getListFull();
            lkNhanVien.Properties.DisplayMember = "HOTEN";
            lkNhanVien.Properties.ValueMember = "MANV";
        }
        void loadLoaiCa()
        {
            cboLoaiCa.DataSource = _loaica.getList();
            cboLoaiCa.DisplayMember = "TENLOAICA";
            cboLoaiCa.ValueMember = "IDLOAICA";
        }
        private void ShowHideControls(bool isEditing)
        {
            btnLuuCV.Enabled = !isEditing;
            btnHuyCV.Enabled = !isEditing;
            btnPrintCV.Enabled = isEditing;
            btnSuaCV.Enabled = isEditing;
            btnThemCV.Enabled = isEditing;
            btnXoaCV.Enabled = isEditing;
            btnDongCV.Enabled = isEditing;
            txtNoiDung.Enabled = !isEditing;
            spSoGio.Enabled = !isEditing;
            lkNhanVien.Enabled = !isEditing;
            cboLoaiCa.Enabled = !isEditing;
        }
        private void btnThemCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtNoiDung.Text = string.Empty;
            spSoGio.EditValue = 0;
            lkNhanVien.EditValue = 0;
            cboLoaiCa.SelectedIndex = 0;
            _isAdding = true;
            ShowHideControls(false);
        }

        private void btnSuaCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _isAdding = false;
            ShowHideControls(false);
        }

        private void btnXoaCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _tangca.Delete(_id, 1); // User ID here
                LoadData();
            }
        }

        private void btnLuuCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            LoadData();
            _isAdding = false;
            ShowHideControls(true);
        }

        private void btnHuyCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _isAdding = false;
            ShowHideControls(true);
            txtNoiDung.Text = string.Empty;
            spSoGio.EditValue = 0;
        }

        private void btnPrintCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDongCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void SaveData()
        {
            if (_isAdding)
            {
                TB_TANGCA tc = new TB_TANGCA();
                tc.IDLOAICA = int.Parse(cboLoaiCa.SelectedValue.ToString());
                tc.SOGIO = double.Parse(spSoGio.EditValue.ToString());
                tc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                tc.GHICHU = txtNoiDung.Text;
                tc.NGAY = DateTime.Now.Day;
                tc.THANG = DateTime.Now.Month;
                tc.NAM = DateTime.Now.Year;
                var lc = _loaica.getItem(int.Parse(cboLoaiCa.SelectedValue.ToString()));
                var cg = _config.getItem("TANGCA");
                tc.SOTIEN = tc.SOGIO * lc.HESO*int.Parse(cg.Value);
                tc.CREATED_BY = 1; // User ID here
                tc.CREATED_DATE = DateTime.Now;
                _tangca.Add(tc);
            }
            else
            {
                var pc = _tangca.GetItem(_id);
                pc.IDLOAICA = int.Parse(cboLoaiCa.SelectedValue.ToString());
                pc.SOGIO = double.Parse(spSoGio.EditValue.ToString());
                pc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                pc.GHICHU = txtNoiDung.Text;
                pc.NGAY = DateTime.Now.Day;
                pc.THANG = DateTime.Now.Month;
                pc.NAM = DateTime.Now.Year;
                var lc = _loaica.getItem(int.Parse(cboLoaiCa.SelectedValue.ToString()));
                var cg = _config.getItem("TANGCA");
                pc.SOTIEN = pc.SOGIO * lc.HESO * int.Parse(cg.Value);
                pc.UPDATED_BY = 1; // User ID here
                pc.UPDATED_DATE = DateTime.Now;
                _tangca.Update(pc);
            }
        }

        private void gc_DanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                txtNoiDung.Text = gvDanhSach.GetFocusedRowCellValue("GHICHU").ToString();
                spSoGio.EditValue = gvDanhSach.GetFocusedRowCellValue("SOGIO");
                lkNhanVien.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV");
                cboLoaiCa.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDLOAICA");
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.b2_2;
                Image resizedImg = new Bitmap(img, new Size(30, 30));
                e.Graphics.DrawImage(resizedImg, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }

}