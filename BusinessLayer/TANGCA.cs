using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class TANGCA
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        // Lấy một mục
        public TB_TANGCA GetItem(int id)
        {
            return db.TB_TANGCA.FirstOrDefault(x => x.ID == id);
        }

        // Thêm một mục mới
        public TB_TANGCA Add(TB_TANGCA tc)
        {
            try
            {
                db.TB_TANGCA.Add(tc);
                db.SaveChanges();
                return tc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Lấy danh sách
        public List<TB_TANGCA> GetList()
        {
            return db.TB_TANGCA.ToList();
        }

        public List<TANGCA_DTO> GetListFull()
        {
            using (var db = new QLNHANSUEntities())
            {
                var lstTangCa = db.TB_TANGCA.ToList();
                List<TANGCA_DTO> lstDTO = new List<TANGCA_DTO>();
                TANGCA_DTO tc;
                foreach (var item in lstTangCa)
                {
                    tc = new TANGCA_DTO();
                    tc.ID = item.ID;
                    tc.NAM = item.NAM;
                    tc.NGAY = item.NGAY;
                    tc.THANG = item.THANG;
                    tc.SOGIO = item.SOGIO;
                    tc.MANV = item.MANV;
                    var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                    tc.HOTEN = nv.HOTEN;
                    tc.IDLOAICA = item.IDLOAICA;
                    var lc = db.TB_LOAICA.FirstOrDefault(l => l.IDLOAICA == item.IDLOAICA);
                    tc.TENLOAICA = lc.TENLOAICA;
                    tc.HESO = lc.HESO;
                    tc.SOTIEN = item.SOTIEN;
                    tc.GHICHU = item.GHICHU;
                    tc.CREATED_BY = item.CREATED_BY;
                    tc.CREATED_DATE = item.CREATED_DATE;
                    tc.UPDATED_BY = item.UPDATED_BY;
                    tc.UPDATED_DATE = item.UPDATED_DATE;
                    tc.DELETED_BY = item.DELETED_BY;
                    tc.DELETED_DATE = item.DELETED_DATE;
                    lstDTO.Add(tc);
                }
                return lstDTO;
            }
        }
        // Cập nhật một mục
        public TB_TANGCA Update(TB_TANGCA dt)
        {
            try
            {
                var _DT = db.TB_TANGCA.FirstOrDefault(x => x.ID == dt.ID);
                if (_DT != null)
                {
                    _DT.NAM  = dt.NAM;
                    _DT.THANG  = dt.THANG;
                    _DT.NGAY  = dt.NGAY;
                    _DT.SOGIO = dt.SOGIO;
                    _DT.SOTIEN = dt.SOTIEN;
                    _DT.MANV  = dt.MANV;
                    _DT.IDLOAICA = dt.IDLOAICA;
                    _DT.GHICHU  = dt.GHICHU;
                    _DT.UPDATED_BY = dt.UPDATED_BY;
                    _DT.UPDATED_DATE = dt.UPDATED_DATE;
                    //  _DT.UPDATED_BY = 1; // Giả sử cố định là 1, bạn có thể điều chỉnh theo yêu cầu của bạn
                    //  _DT.UPDATED_DATE = DateTime.Now;
                    db.SaveChanges();
                    
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Xóa một mục
        public void Delete(int id, int user)
        {
            try
            {
                var _DT = db.TB_TANGCA.FirstOrDefault(x => x.ID == id);
                if (_DT != null)
                {
                    _DT.DELETED_BY = user;
                    _DT.DELETED_DATE = DateTime.Now;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
