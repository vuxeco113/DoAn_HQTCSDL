using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class PHIEU_NHAP_THUOC_BLL
    {
        public PHIEU_NHAP_THUOC_DAL pntDAL { get; set; }
        public PHIEU_NHAP_THUOC_BLL() 
        {
            pntDAL= new PHIEU_NHAP_THUOC_DAL();
        }
        public int Dem_SL_PN()
        {
            return pntDAL.Dem_SL_PN();
        }
        public bool insert_PN(PHIEU_NHAP_THUOC_DTO tmp)
        {
            return pntDAL.insert_PN(tmp);
        }
    }
}
