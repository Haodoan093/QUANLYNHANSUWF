using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
   public class LOAICA

    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        //get item
        public TB_LOAICA getItem(int id)
        {
            return db.TB_LOAICA.FirstOrDefault(x => x.IDLOAICA == id);
        }
        //add
        public TB_LOAICA Add(TB_LOAICA dt)
        {
            try
            {
                db.TB_LOAICA.Add(dt);
              
                db.SaveChanges();
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }


        //get list
        public List<TB_LOAICA> getList()
        {
            return db.TB_LOAICA.ToList();
        }

        //update
        public TB_LOAICA Update(TB_LOAICA dt)
        {
            try
            {
                var _DT = db.TB_LOAICA.FirstOrDefault(x => x.IDLOAICA == dt.IDLOAICA);
                _DT.TENLOAICA = dt.TENLOAICA;
                _DT.HESO = dt.HESO;
                _DT.UPDATED_BY = 1;
                _DT.UPDATED_DATE = DateTime.Now;
                db.SaveChanges();
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }
        //Delete
        public void Delete(int id,int USER)
        {
            try
            {
                var _DT = db.TB_LOAICA.FirstOrDefault(x => x.IDLOAICA == id);
                _DT.DELETED_BY = USER;
                _DT.DELETED_DATE = DateTime.Now;
               
                db.SaveChanges();


            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }

    }
}
