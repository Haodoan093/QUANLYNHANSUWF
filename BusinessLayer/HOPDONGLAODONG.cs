using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;
namespace BusinessLayer
{
    public class HOPDONGLAODONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        // Lấy một nhân viên theo ID
        public TB_HOPDONG getItem(string sohd)
        {
            return db.TB_HOPDONG.FirstOrDefault(x => x.SOHD == sohd);
        }
        public List<HOPDONG_DTO> getItemFull(string sohd)
        {
            List<TB_HOPDONG> lstHD = db.TB_HOPDONG.Where(x=>x.SOHD==sohd).ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                hd.NGAYBATDAU = item.NGAYBATDAU.Value.ToString("dd/MM/yyyy");
                hd.NGAYKETTHUC = item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy");
                hd.NGAYKY = "Hà nội, ngày " + item.NGAYKY.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng "
                    + item.NGAYKY.Value.ToString("dd/MM/yyyy").Substring(3,2) + " năm 2024";
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.NOIDUNG = item.NOIDUNG;
                hd.MANV = item.MANV;
                hd.THOIHAN = item.THOIHAN;
                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.CCCD = nv.CCCD;
                hd.DIACHI = nv.DIACHI;
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.EMAIL = nv.EMAIL;
                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.MACT = item.MACT;
                lstDTO.Add(hd);

            }
            return lstDTO;
        }
        public List<TB_HOPDONG> getList()
        {
            return db.TB_HOPDONG.ToList();
        }
        public List<HOPDONG_DTO> getListFull()
        {
            List<TB_HOPDONG> lstHD = db.TB_HOPDONG.ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach( var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                hd.NGAYBATDAU = item.NGAYBATDAU.Value.ToString("dd/MM/yyyy");
                hd.NGAYKETTHUC = item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy");
                hd.NGAYKY = item.NGAYKY.Value.ToString("dd/MM/yyyy");
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.NOIDUNG = item.NOIDUNG;
                hd.MANV = item.MANV;
                hd.THOIHAN = item.THOIHAN;
                var nv= db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.CCCD = nv.CCCD;
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.DIACHI = nv.DIACHI;
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.EMAIL = nv.EMAIL;
                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.MACT = item.MACT;
                lstDTO.Add(hd);

            }
            return lstDTO;
        }

        public TB_HOPDONG Add(TB_HOPDONG hopdong)
        {
            try
            {
                db.TB_HOPDONG.Add(hopdong);
                db.SaveChanges();
                return hopdong;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public TB_HOPDONG Update(TB_HOPDONG hopdong)
        {
            try
            {
                var hd = db.TB_HOPDONG.FirstOrDefault(x => x.SOHD == hopdong.SOHD);
                if (hd != null)
                {
                    hd.NGAYBATDAU = hopdong.NGAYBATDAU;
                    hd.NGAYKETTHUC = hopdong.NGAYKETTHUC;
                    hd.NGAYKY = hopdong.NGAYKY;
                    hd.LANKY = hopdong.LANKY;
                    hd.HESOLUONG = hopdong.HESOLUONG;
                    hd.NOIDUNG = hopdong.NOIDUNG;
                    hd.THOIHAN = hopdong.THOIHAN;
                    hd.SOHD = hopdong.SOHD;

                    hd.MANV = hopdong.MANV;
                    hd.UPDATED_BY = hopdong.UPDATED_BY;
                    hd.UPDATED_DATE = hopdong.UPDATED_DATE;
                   

                    hd.MACT = hopdong.MACT;
                    db.SaveChanges();
                }
                return hopdong;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Xóa một nhân viên
        public void Delete(string id,int manv)
        {
            try
            {
                var hd = db.TB_HOPDONG.FirstOrDefault(x => x.SOHD == id);
                if (hd != null)
                {
                    hd.DELETED_BY = manv;
                    hd.DELETED_DATE = DateTime.Now;
                 
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoHopDong()
        {
            var _hd = db.TB_HOPDONG.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOHD;
            }
            else
                return "00000";
        }
        public List<HOPDONG_DTO> getTTlenLuong()
        {
            List<TB_HOPDONG> lstHD = db.TB_HOPDONG
              .Where(x => x.NGAYBATDAU.Value.Year >= DateTime.Now.Year - 2)
              .ToList();

            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                hd.NGAYBATDAU = item.NGAYBATDAU.Value.ToString("dd/MM/yyyy");
                hd.NGAYKETTHUC = item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy");
                hd.NGAYKY = "Hà nội, ngày " + item.NGAYKY.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng "
                    + item.NGAYKY.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm 2024";
              
                hd.MANV = item.MANV;
                hd.THOIHAN = item.THOIHAN;
                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
       

                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
   
  

                lstDTO.Add(hd);

            }
            return lstDTO;
        }
    }
}
