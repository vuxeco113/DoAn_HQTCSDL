using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LUUKHO_BLL
    {
        public LUUKHO_DAL lkDAL { get; set; }
        public LUUKHO_BLL() 
        {
            lkDAL = new LUUKHO_DAL();
        }
        public bool insert_luuKHo(LUUKHO_DTO tmp)
        {
            return lkDAL.insert_LUUKHO(tmp);
        }
        public bool them_SL_LuuKho(CHITIET_PN_THUOC_DTO tmp)
        {
            return lkDAL.ThemSLTon_LuuKho(tmp);
        }
        public List<LUUKHO_DTO> get_all()
        { return lkDAL.get_all(); }
        public bool layThuoc1Loai(CHI_TIET_TOA_THUOC_DTO tmp)
        {
            return lkDAL.Lay1LoaiThuoc_TheoToa(tmp);
        }
    }
}
