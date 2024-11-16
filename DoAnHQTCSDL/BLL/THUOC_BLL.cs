using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class THUOC_BLL
    {
        public THUOC_DAL tDAL { get; set; }
        public THUOC_BLL() { 
            tDAL = new THUOC_DAL();
        }
        public List<THUOC_DTO>get_all()
        {
            return tDAL.get_all();
        }
        public bool Them_Thuoc(THUOC_DTO tmp)
        {
            return tDAL.Them_Thuoc(tmp);
        }
        public bool Sua_Thuoc(THUOC_DTO tmp)
        {
            return tDAL.Sua_Thuoc(tmp);
        }
        public bool Xoa_Thuoc(THUOC_DTO tmp)
        {
            return tDAL.Xoa_Thuoc(tmp) ;
        }
    }
}
