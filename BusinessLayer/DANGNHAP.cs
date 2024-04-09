using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class DANGNHAP { 
 QLNHANSUEntities db = new QLNHANSUEntities(); // Khởi tạo đối tượng để truy cập CSDL

    //// Kiểm tra đăng nhập
    public bool CheckLogin(string username, string password)
    {
        try
        {

            var user = db.TB_TAIKHOAN.FirstOrDefault(x => x.USERNAME == username && x.PASSWORD == password);


            if (user != null)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        catch (Exception ex)
        {

            throw new Exception("Lỗi: " + ex.Message);
        }
    }
}
}

