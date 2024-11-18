using DTO;
using DAL;
using System.Collections.Generic;

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
            return bacSiDal.get_all();
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
    }
}
