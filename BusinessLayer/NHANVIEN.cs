using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class NHANVIEN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        // Lấy một nhân viên theo ID
        public TB_NHANVIEN getItem(int id)
        {
            return db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == id);
        }
        public NHANVIEN_DTO getItemFull(int id )
        {
            var item = db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == id);

            NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();
                nvDTO.MANV = item.MANV;
                nvDTO.HOTEN = item.HOTEN;
                nvDTO.HINHANH = item.HINHANH;
                nvDTO.GIOITINH = item.GIOITINH;
                nvDTO.DATHOIVIEC = item.DATHOIVIEC;
                nvDTO.NGAYSINH = item.NGAYSINH.Value.ToString("dd/MM/yyyy"); ;
                nvDTO.CCCD = item.CCCD;
                nvDTO.DIENTHOAI = item.DIENTHOAI;
                nvDTO.DIACHI = item.DIACHI;
                nvDTO.EMAIL = item.EMAIL;

                //bo phan
                nvDTO.IDBP = item.IDBP;
                var bp = db.TB_BOPHAN.FirstOrDefault(x => x.IDBP == nvDTO.IDBP);
                nvDTO.TENBP = bp.TENBP;
                //chuc vu
                nvDTO.IDCV = item.IDCV;
                var cv = db.TB_CHUCVU.FirstOrDefault(x => x.IDCV == nvDTO.IDCV);
                nvDTO.TENCV = cv.TENCV;
                //dan toc
                nvDTO.IDDT = item.IDDT;
                var dt = db.TB_DANTOC.FirstOrDefault(x => x.ID == nvDTO.IDDT);
                nvDTO.TENDT = dt.TENDT;

                //ton giao
                nvDTO.IDTG = item.IDTG;
                var tg = db.TB_TONGIAO.FirstOrDefault(x => x.ID == nvDTO.IDTG);
                nvDTO.TENTG = tg.TENTG;

                //phong ban
                nvDTO.IDPB = item.IDPB;
                var pb = db.TB_PHONGBAN.FirstOrDefault(x => x.IDPB == nvDTO.IDPB);
                nvDTO.TENPB = pb.TENPB;

                //trinh do
                nvDTO.IDTD = item.IDTD;
                var td = db.TB_TRINHDO.FirstOrDefault(x => x.IDTD == nvDTO.IDTD);
                nvDTO.TENTD = td.TENTD;

                nvDTO.IDCT = item.IDCT;
                var ct = db.TB_CONGTY.FirstOrDefault(x => x.IDCT == nvDTO.IDCT);
                nvDTO.TENCT = ct.TENCT;

            return nvDTO;

        }
        public List<NHANVIEN_DTO> getListFull()
        {
            var lstNV = db.TB_NHANVIEN.ToList();
            List<NHANVIEN_DTO> lstNVDTO = new List<NHANVIEN_DTO>();
            NHANVIEN_DTO nvDTO;
            foreach (var item in lstNV)
            {
                nvDTO = new NHANVIEN_DTO();
                nvDTO.MANV = item.MANV;
                nvDTO.HOTEN = item.HOTEN;
                nvDTO.HINHANH = item.HINHANH;
                nvDTO.GIOITINH = item.GIOITINH;
                nvDTO.DATHOIVIEC = item.DATHOIVIEC;
                nvDTO.NGAYSINH = item.NGAYSINH.Value.ToString("dd/MM/yyyy"); ;
                nvDTO.CCCD = item.CCCD;
                nvDTO.DIENTHOAI = item.DIENTHOAI;
                nvDTO.DIACHI = item.DIACHI;
                nvDTO.EMAIL = item.EMAIL;

                //bo phan
                nvDTO.IDBP = item.IDBP;
                 var bp= db.TB_BOPHAN.FirstOrDefault(x => x.IDBP == nvDTO.IDBP);
                nvDTO.TENBP = bp.TENBP;
                //chuc vu
                nvDTO.IDCV = item.IDCV;
                var cv = db.TB_CHUCVU.FirstOrDefault(x => x.IDCV == nvDTO.IDCV);
                nvDTO.TENCV = cv.TENCV;
                //dan toc
                nvDTO.IDDT = item.IDDT;
                var dt = db.TB_DANTOC.FirstOrDefault(x => x.ID == nvDTO.IDDT);
                nvDTO.TENDT = dt.TENDT;

                //ton giao
                nvDTO.IDTG = item.IDTG;
                var tg = db.TB_TONGIAO.FirstOrDefault(x => x.ID == nvDTO.IDTG);
                nvDTO.TENTG = tg.TENTG;

                //phong ban
                nvDTO.IDPB = item.IDPB;
                var pb = db.TB_PHONGBAN.FirstOrDefault(x => x.IDPB == nvDTO.IDPB);
                nvDTO.TENPB = pb.TENPB;

                //trinh do
                nvDTO.IDTD = item.IDTD;
                var td = db.TB_TRINHDO.FirstOrDefault(x => x.IDTD == nvDTO.IDTD);
                nvDTO.TENTD = td.TENTD;

                nvDTO.IDCT = item.IDCT;
                var ct = db.TB_CONGTY.FirstOrDefault(x => x.IDCT == nvDTO.IDCT);
                nvDTO.TENCT = ct.TENCT;

                lstNVDTO.Add(nvDTO);

            }
            return lstNVDTO;

        }
            

        // Thêm một nhân viên
        public TB_NHANVIEN Add(TB_NHANVIEN employee)
        {
            try
            {
                db.TB_NHANVIEN.Add(employee);
                db.SaveChanges();
                return employee;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Lấy danh sách tất cả các nhân viên
        public List<TB_NHANVIEN> getList()
        {
            return db.TB_NHANVIEN.ToList();
        }

        // Cập nhật thông tin của nhân viên
        public TB_NHANVIEN Update(TB_NHANVIEN employee)
        {
            try
            {
                var emp = db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == employee.MANV);
                if (emp != null)
                {
                    emp.HOTEN = employee.HOTEN;
                    emp.GIOITINH = employee.GIOITINH;
                    emp.NGAYSINH = employee.NGAYSINH;
                    emp.CCCD = employee.CCCD;
                    emp.DIENTHOAI = employee.DIENTHOAI;
                    emp.HINHANH = employee.HINHANH;
                    emp.EMAIL = employee.EMAIL;
                    emp.DIACHI = employee.DIACHI;
                    emp.IDBP = employee.IDBP;
                    emp.IDCV = employee.IDCV;
                    emp.IDPB = employee.IDPB;
                    emp.DATHOIVIEC = employee.DATHOIVIEC;
                    emp.IDTD = employee.IDTD;
                    emp.IDDT = employee.IDDT;
                    emp.IDTG = employee.IDTG;

                    emp.IDCT = employee.IDCT;
                    db.SaveChanges();
                }
                return employee;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Xóa một nhân viên
        public void Delete(int id)
        {
            try
            {
                var emp = db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == id);
                if (emp != null)
                {
                    db.TB_NHANVIEN.Remove(emp);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
  
        public List<NHANVIEN_DTO> getSinhNhat()
        {
         var lstNV = db.TB_NHANVIEN.Where(x => x.NGAYSINH.Value.Month == DateTime.Now.Month).ToList();
            List<NHANVIEN_DTO> lstNVDTO = new List<NHANVIEN_DTO>();
            NHANVIEN_DTO nvDTO;
            foreach (var item in lstNV)
            {
                nvDTO = new NHANVIEN_DTO();
                nvDTO.MANV = item.MANV;
                nvDTO.HOTEN = item.HOTEN;
                nvDTO.HINHANH = item.HINHANH;
                nvDTO.GIOITINH = item.GIOITINH;
                nvDTO.DATHOIVIEC = item.DATHOIVIEC;
                nvDTO.NGAYSINH = item.NGAYSINH.Value.ToString("dd/MM/yyyy"); ;




                nvDTO.CCCD = item.CCCD;
                nvDTO.DIENTHOAI = item.DIENTHOAI;
                nvDTO.DIACHI = item.DIACHI;
                nvDTO.EMAIL = item.EMAIL;

                //bo phan
                nvDTO.IDBP = item.IDBP;
                var bp = db.TB_BOPHAN.FirstOrDefault(x => x.IDBP == nvDTO.IDBP);
                nvDTO.TENBP = bp.TENBP;
                //chuc vu
                nvDTO.IDCV = item.IDCV;
                var cv = db.TB_CHUCVU.FirstOrDefault(x => x.IDCV == nvDTO.IDCV);
                nvDTO.TENCV = cv.TENCV;
                //dan toc
                nvDTO.IDDT = item.IDDT;
                var dt = db.TB_DANTOC.FirstOrDefault(x => x.ID == nvDTO.IDDT);
                nvDTO.TENDT = dt.TENDT;

                //ton giao
                nvDTO.IDTG = item.IDTG;
                var tg = db.TB_TONGIAO.FirstOrDefault(x => x.ID == nvDTO.IDTG);
                nvDTO.TENTG = tg.TENTG;

                //phong ban
                nvDTO.IDPB = item.IDPB;
                var pb = db.TB_PHONGBAN.FirstOrDefault(x => x.IDPB == nvDTO.IDPB);
                nvDTO.TENPB = pb.TENPB;

                //trinh do
                nvDTO.IDTD = item.IDTD;
                var td = db.TB_TRINHDO.FirstOrDefault(x => x.IDTD == nvDTO.IDTD);
                nvDTO.TENTD = td.TENTD;

                nvDTO.IDCT = item.IDCT;
                var ct = db.TB_CONGTY.FirstOrDefault(x => x.IDCT == nvDTO.IDCT);
                nvDTO.TENCT = ct.TENCT;

                lstNVDTO.Add(nvDTO);

            }
            return lstNVDTO;

        }

    }
}
