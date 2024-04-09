using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BOPHAN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        // Lấy một mục theo ID
        public TB_BOPHAN getItem(int id)
        {
            return db.TB_BOPHAN.Where(x=>x.IDBP==id).FirstOrDefault(x => x.IDBP == id);
        }

        // Thêm một mục
        public TB_BOPHAN Add(TB_BOPHAN bp)
        {
            try
            {
                db.TB_BOPHAN.Add(bp);
                db.SaveChanges();
                return bp;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Lấy danh sách tất cả các mục
        public List<TB_BOPHAN> getList()
        {
            return db.TB_BOPHAN.ToList();
        }

        // Cập nhật một mục
        public TB_BOPHAN Update(TB_BOPHAN bp)
        {
            try
            {
                var _bp = db.TB_BOPHAN.FirstOrDefault(x => x.IDBP == bp.IDBP);
                if (_bp != null)
                {
                    _bp.TENBP = bp.TENBP;
                    // Cập nhật các trường khác tương tự nếu cần
                    db.SaveChanges();
                }
                return bp;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Xóa một mục
        public void Delete(int id)
        {
            try
            {
                var _bp = db.TB_BOPHAN.FirstOrDefault(x => x.IDBP == id);
                if (_bp != null)
                {
                    db.TB_BOPHAN.Remove(_bp);
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
