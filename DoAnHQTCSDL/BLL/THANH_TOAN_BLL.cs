using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class THANH_TOAN_BLL
    {
        public THANH_TOAN_DAL ttDAL { get; set; }
        public THANH_TOAN_BLL()
        {
            ttDAL= new THANH_TOAN_DAL();
        }
        public bool Them_ThanhToan_ToaThuoc(THANH_TOAN_DTO tmp)
        {
            return ttDAL.inSert_ThanhToan_ToaThuoc(tmp);
        }
        public int Dem_SL_THANHTAON_ToaThuoc()
        {
            return ttDAL.Dem_SL_ToaThuoc();
        }
    }
}
