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
using BusinessLayer;
using DataLayer;

namespace QLNHANSU
{
    public partial class frmLoaiCong : DevExpress.XtraEditors.XtraForm
    {
        LOAICONG _loaiCong;
        bool _isAdding;
        int _id;

        public frmLoaiCong()
        {
            InitializeComponent();
            _loaiCong = new LOAICONG();
        }

        private void frmLoaiCong_Load(object sender, EventArgs e)
        {
            _isAdding = false;
            LoadData();
            ShowHideControls(true);
        }

        private void LoadData()
        {
            gcDanhSachCV.DataSource = _loaiCong.GetList();
            gvDanhSachCV.OptionsBehavior.Editable = false;
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
            txtTenCV.Enabled = !isEditing;
            spHeSo.Enabled = !isEditing;
        }

        private void btnThemCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenCV.Text = string.Empty;
            spHeSo.EditValue = 0;
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
                _loaiCong.Delete(_id, 1); // User ID here
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
            txtTenCV.Text = string.Empty;
            spHeSo.EditValue = 0;
        }

        private void btnPrintCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Code for printing
        }

        private void btnDongCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhSachCV_Click(object sender, EventArgs e)
        {
            if (gvDanhSachCV.RowCount > 0)
            {
                _id = int.Parse(gvDanhSachCV.GetFocusedRowCellValue("IDLC").ToString());
                txtTenCV.Text = gvDanhSachCV.GetFocusedRowCellValue("TENLC").ToString();
                spHeSo.Text = gvDanhSachCV.GetFocusedRowCellValue("HESO").ToString();
            }
        }

        private void gvDanhSachCV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.b2_2;
                Image resizedImg = new Bitmap(img, new Size(30, 30));
                e.Graphics.DrawImage(resizedImg, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        void SaveData()
        {
            if (_isAdding)
            {
                TB_LOAICONG cv = new TB_LOAICONG();
                cv.TENLC = txtTenCV.Text;
                cv.HESO = double.Parse(spHeSo.EditValue.ToString());
                cv.CREATED_BY = 1; // User ID here
                cv.CREATED_DATE = DateTime.Now;
                _loaiCong.Add(cv);
            }
            else
            {
                var cv = _loaiCong.GetItem(_id);
                cv.TENLC = txtTenCV.Text;
                cv.HESO = double.Parse(spHeSo.EditValue.ToString());
                _loaiCong.Update(cv);
            }
        }
    }
}
