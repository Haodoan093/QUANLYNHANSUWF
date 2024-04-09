using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;
namespace BusinessLayer
{
     public class PHUCAP
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        // Lấy một mục
        public TB_NHANVIEN_PHUCAP GetItem(int id)
        {
            return db.TB_NHANVIEN_PHUCAP.FirstOrDefault(x => x.ID == id);
        }

        // Thêm một mục mới
        public TB_NHANVIEN_PHUCAP Add(TB_NHANVIEN_PHUCAP dt)
        {
            try
            {
                db.TB_NHANVIEN_PHUCAP.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Lấy danh sách
        public List<NHANVIEN_PHUCAP_DTO> GetListFull()
        {
            var listnvpc= db.TB_NHANVIEN_PHUCAP.ToList();
            List<NHANVIEN_PHUCAP_DTO> lstDTO = new List<NHANVIEN_PHUCAP_DTO>();
            NHANVIEN_PHUCAP_DTO nvpc;
            NHANVIEN _nhanvien = new NHANVIEN();
            foreach (var item in listnvpc)
            {
                nvpc = new NHANVIEN_PHUCAP_DTO();
                nvpc.ID = item.ID;
                nvpc.MANV = item.MANV;
                var nv = _nhanvien.getItemFull(int.Parse(item.MANV.ToString()));
                nvpc.HOTEN = nv.HOTEN;
                nvpc.TENCV = nv.TENCV;
                nvpc.IDPC = item.IDPC;
                var pc = db.TB_PHUCAP.FirstOrDefault(x => x.IDPC == item.IDPC);
                nvpc.TENPC = pc.TENPC;
                nvpc.NOIDUNG = item.NOIDUNG;
                nvpc.NGAY = item.NGAY;
                nvpc.SOTIEN = item.SOTIEN;
                nvpc.CREATED_BY = item.CREATED_BY;
                nvpc.CREATED_DATE = item.CREATED_DATE;
                nvpc.UPDATED_BY = item.UPDATED_BY;
                nvpc.UPDATED_DATE = item.UPDATED_DATE;
                nvpc.DELETED_BY = item.DELETED_BY;
                nvpc.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(nvpc);
            }
            return lstDTO;
        }
        public TB_PHUCAP getItemPC(int id)
        {
            return db.TB_PHUCAP.FirstOrDefault(x=>x.IDPC==id);
        }
        public List<TB_PHUCAP> getListPC()
        {
            return db.TB_PHUCAP.ToList();
        } 
        // Cập nhật một mục
        public TB_NHANVIEN_PHUCAP Update(TB_NHANVIEN_PHUCAP pc)
        {
            try
            {
                var _pc = db.TB_NHANVIEN_PHUCAP.FirstOrDefault(x => x.ID == pc.ID);
                if (_pc != null)
                {
                    _pc.IDPC = pc.IDPC;
                    _pc.MANV = pc.MANV;
                    _pc.NGAY = pc.NGAY;
                    _pc.NOIDUNG = pc.NOIDUNG;
                    _pc.SOTIEN = pc.SOTIEN;
                    _pc.UPDATED_BY = 1; // Giả sử cố định là 1, bạn có thể điều chỉnh theo yêu cầu của bạn
                    _pc.UPDATED_DATE = DateTime.Now;
                    db.SaveChanges();
                }
                return _pc;
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
                var _pc = db.TB_NHANVIEN_PHUCAP.FirstOrDefault(x => x.ID == id);
                if (_pc != null)
                {
                    _pc.DELETED_BY = user;
                    _pc.DELETED_DATE = DateTime.Now;
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
