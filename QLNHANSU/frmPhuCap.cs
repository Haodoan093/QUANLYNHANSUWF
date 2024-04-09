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
    public partial class frmPhuCap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhuCap()
        {
            InitializeComponent();
        }
        PHUCAP _phuCap;
        NHANVIEN _nhanvien;
        bool _isAdding;
        int _id;
        private void frmPhuCap_Load(object sender, EventArgs e)
        {
            _isAdding = false;
            _phuCap = new PHUCAP();
            _nhanvien = new NHANVIEN();
            ShowHideControls(true);
            LoadData();
            loadNhanVien();
            loadPhuCap();
            cboPhuCap.SelectedIndexChanged += CboPhuCap_SelectedIndexChanged;
            
        }

        private void CboPhuCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pc = _phuCap.getItemPC(int.Parse(cboPhuCap.SelectedValue.ToString()));
            if (pc != null)
            {
                spSoTien.EditValue = pc.SOTIEN;
            }
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _phuCap.GetListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadNhanVien()
        {
            lkNhanVien.Properties.DataSource = _nhanvien.getListFull();
            lkNhanVien.Properties.DisplayMember = "HOTEN";
            lkNhanVien.Properties.ValueMember = "MANV";
        }
        void loadPhuCap()
        {
            cboPhuCap.DataSource = _phuCap.getListPC();
            cboPhuCap.DisplayMember = "TENPC";
            cboPhuCap.ValueMember = "IDPC";
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
            spSoTien.Enabled = !isEditing;
            lkNhanVien.Enabled = !isEditing;
            cboPhuCap.Enabled = !isEditing;
        }
        private void btnThemCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtNoiDung.Text = string.Empty;
            spSoTien.EditValue = 0;
            lkNhanVien.EditValue = 0;
            cboPhuCap.SelectedIndex = 0;
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
                _phuCap.Delete(_id, 1); // User ID here
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
        void SaveData()
        {
            if (_isAdding)
            {
                TB_NHANVIEN_PHUCAP pc = new TB_NHANVIEN_PHUCAP();
                pc.IDPC = int.Parse(cboPhuCap.SelectedValue.ToString());
                pc.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                pc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                pc.NOIDUNG = txtNoiDung.Text;
                pc.NGAY = DateTime.Now;
                pc.CREATED_BY = 1; // User ID here
                pc.CREATED_DATE = DateTime.Now;
                _phuCap.Add(pc);
            }
            else
            {
                var pc = _phuCap.GetItem(_id);
                pc.IDPC = int.Parse(cboPhuCap.SelectedValue.ToString());
                pc.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                pc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                pc.NOIDUNG = txtNoiDung.Text;
                pc.NGAY = DateTime.Now;
                pc.UPDATED_BY = 1; // User ID here
                pc.UPDATED_DATE = DateTime.Now;
                _phuCap.Update(pc);
            }
        }
        private void btnHuyCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _isAdding = false;
            ShowHideControls(true);
            txtNoiDung.Text = string.Empty;
            spSoTien.EditValue = 0;
        }

        private void btnPrintCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDongCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                txtNoiDung.Text = gvDanhSach.GetFocusedRowCellValue("NOIDUNG").ToString();
                spSoTien.EditValue = gvDanhSach.GetFocusedRowCellValue("SOTIEN");
                lkNhanVien.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV");
                cboPhuCap.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDPC");
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