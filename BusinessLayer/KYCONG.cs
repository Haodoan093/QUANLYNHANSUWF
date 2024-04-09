using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
   public class KYCONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public TB_KYCONG GetItem(int makycong)
        {
            return db.TB_KYCONG.FirstOrDefault(x => x.MAKYCONG == makycong);
        }
        public List<TB_KYCONG> getList()
        {
            return db.TB_KYCONG.ToList();
        }
        public TB_KYCONG Add(TB_KYCONG kc)
        {
            try
            {
                db.TB_KYCONG.Add(kc);
                db.SaveChanges();
                return kc;
            } 
            catch(Exception ex)

            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_KYCONG Update(TB_KYCONG kc)
        {
            try
            {
                var _kc = db.TB_KYCONG.FirstOrDefault(x => x.MAKYCONG == kc.MAKYCONG);
                _kc.MAKYCONG = kc.MAKYCONG;
                _kc.NAM = kc.NAM;
                _kc.THANG = kc.THANG;
                _kc.KHOA = kc.KHOA;
                _kc.NGAYCONGTRONGTHANG = kc.NGAYCONGTRONGTHANG;
                _kc.NGAYTINHCONG = kc.NGAYTINHCONG;
                _kc.TRANGTHAI = kc.TRANGTHAI;
                _kc.UPDATED_BY = kc.UPDATED_BY;
                _kc.UPDATED_DATE = kc.UPDATED_DATE;
                db.SaveChanges();
                return kc;
            }
            catch (Exception ex)

            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void  Delete(int makycong, int iduser)
        {
            try
            {
                var _kc = db.TB_KYCONG.FirstOrDefault(x => x.MAKYCONG == makycong);
                _kc.DELETED_BY = iduser;
                _kc.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
                
            }
            catch (Exception ex)

            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
/*        public string MaxKyCong()
        {
            var _hd = db.TB_KYCONG.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.MAKYCONG;
            }
            else
                return "00000";
        }*/
    }
}
