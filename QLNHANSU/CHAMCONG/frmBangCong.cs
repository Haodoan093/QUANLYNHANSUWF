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

namespace QLNHANSU.CHAMCONG
{
    public partial class frmBangCong : DevExpress.XtraEditors.XtraForm
    {
        KYCONG _kycong;
        bool _isAdding;
        int _makycong;
        public frmBangCong()
        {
            InitializeComponent();
            _kycong = new KYCONG(); // Initialize _kycong
        }

        

        private void frmBangCong_Load(object sender, EventArgs e)
        {
            _isAdding = false;
            LoadData();
            ShowHideControls(true);
            cboNam.Text = DateTime.Now.Year.ToString();
            cboThang.Text = DateTime.Now.Month.ToString();
        }

        private void LoadData()
        {
            gcDanhSachCV.DataSource = _kycong.getList();
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
        }

        private void btnThemCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            cboNam.Text = DateTime.Now.Year.ToString();
            cboThang.Text = DateTime.Now.Month.ToString();
            chkKhoa.Checked = false;
            chkTrangThai.Checked = false;
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
                try
                {
                    _kycong.Delete(_makycong, 1); // User ID here
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuuCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveData();
                LoadData();
                _isAdding = false;
                ShowHideControls(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _isAdding = false;
            ShowHideControls(true);
        }

        private void btnPrintCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Implement printing functionality here if needed
        }

        private void btnDongCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    
        void SaveData()
        {
            if (_isAdding)
            {
                TB_KYCONG kc = new TB_KYCONG();
                kc.MAKYCONG = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);
                kc.NAM = int.Parse(cboNam.Text);
                kc.THANG = int.Parse(cboThang.Text); // Corrected to parse cboThang.Text
                kc.KHOA = chkKhoa.Checked;
                kc.TRANGTHAI = chkTrangThai.Checked;
                kc.MACTY = 1;
                kc.NGAYCONGTRONGTHANG = Functions.Demngaylamviectrongthang(int.Parse(cboThang.Text), int.Parse(cboNam.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                kc.CREATED_BY = 1; // User ID here
                kc.CREATED_DATE = DateTime.Now;
                _kycong.Add(kc);
            }
            else
            {
                var kc = _kycong.GetItem(_makycong);
                kc.MAKYCONG = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);
                kc.NAM = int.Parse(cboNam.Text);
                kc.THANG = int.Parse(cboThang.Text); // Corrected to parse cboThang.Text
                kc.KHOA = chkKhoa.Checked;
                kc.TRANGTHAI = chkTrangThai.Checked;
                kc.NGAYCONGTRONGTHANG = Functions.Demngaylamviectrongthang(int.Parse(cboThang.Text), int.Parse(cboNam.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                kc.CREATED_BY = 1; // User ID here
                kc.CREATED_DATE = DateTime.Now;
                _kycong.Update(kc);
            }
        }

        private void gvDanhSachCV_Click(object sender, EventArgs e)
        {
            if (gvDanhSachCV.RowCount > 0)
            {
                _makycong = int.Parse(gvDanhSachCV.GetFocusedRowCellValue("MAKYCONG").ToString());
                cboNam.Text = gvDanhSachCV.GetFocusedRowCellValue("NAM").ToString();
                cboThang.Text = gvDanhSachCV.GetFocusedRowCellValue("THANG").ToString();
                chkKhoa.Checked = bool.Parse(gvDanhSachCV.GetFocusedRowCellValue("KHOA").ToString());
                chkTrangThai.Checked = bool.Parse(gvDanhSachCV.GetFocusedRowCellValue("TRANGTHAI").ToString());
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

        private void btnXemBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangCongChiTiet frm = new frmBangCongChiTiet();
            frm._makycong = _makycong;
            frm._thang = int.Parse(cboThang.Text);
            frm._nam = int.Parse(cboNam.Text);
            frm._macty = 1;
            frm.ShowDialog();       
        }
    }
}
