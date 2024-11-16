using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CHI_TIET_TOA_THUOC_BLL
    {
        public CHI_TIET_TOA_THUOC_DAL ctttDAL { get; set; }
        public CHI_TIET_TOA_THUOC_BLL()
        {
            ctttDAL= new CHI_TIET_TOA_THUOC_DAL();
        }
        public List<CHI_TIET_TOA_THUOC_DTO> get_all()
        {
            return ctttDAL.get_all();
        }
    }
}
