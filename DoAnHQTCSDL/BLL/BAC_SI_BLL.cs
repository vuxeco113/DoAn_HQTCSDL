using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class BAC_SI_BLL
    {
        private BAC_SI_DAL bacSiDal;

        // Constructor
        public BAC_SI_BLL()
        {
            bacSiDal = new BAC_SI_DAL();
        }

        // Lấy danh sách tất cả bác sĩ
        public List<BAC_SI_DTO> GetAllBacSi()
        {
            return bacSiDal.GetAll();
        }

        // Thêm một bác sĩ
        public bool ThemBacSi(BAC_SI_DTO bacSi)
        {
            return bacSiDal.Them_BacSi(bacSi);
        }

        // Sửa thông tin bác sĩ
        public bool SuaBacSi(BAC_SI_DTO bacSi)
        {
            return bacSiDal.Sua_BacSi(bacSi);
        }

        // Xóa bác sĩ theo mã
        public bool XoaBacSi(string maBacSi)
        {
            return bacSiDal.Xoa_BacSi(maBacSi);
        }
        public List<KHOA_DTO> LoadKhoa()
        {
            return bacSiDal.LoadKhoa();
        }
        public BAC_SI_DTO DangNhap(string ma, string pass)
        {
            List<BAC_SI_DTO> ds = bacSiDal.GetAll();
            BAC_SI_DTO tmp = ds.SingleOrDefault(s => s.MaBacSi == ma);
            if (tmp == null)
            {
                return null;
            }
            else
            {
                if (tmp.MatKhau != pass)
                {
                    return null;
                }
                else
                {
                    return tmp;
                }
            }
        }
    }
}
