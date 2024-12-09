using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CHITIET_PN_THUOC_BLL
    {
        public CHITIET_PN_THUOC_DAL ctpnDAL { get; set; }
        public CHITIET_PN_THUOC_BLL()
        {
            ctpnDAL= new CHITIET_PN_THUOC_DAL();
        }
        public bool insert_ChiTiet_PN(CHITIET_PN_THUOC_DTO tmp)
        {
            return ctpnDAL.insert_ChiTiet_PN(tmp);
        }
        public List<CHITIET_PN_THUOC_DTO> get_all()
        {
            return ctpnDAL.get_all();   
        }
    }
}
