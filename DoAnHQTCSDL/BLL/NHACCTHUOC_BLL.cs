using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NHACCTHUOC_BLL
    {
        public NHACCTHUOC_DAL nccDAL { get; set; }
        public NHACCTHUOC_BLL()
        {
            nccDAL= new NHACCTHUOC_DAL();
        }
        public List<NHACCTHUOC_DTO>get_all()
        {
            return nccDAL.get_all();
        }
    }
}
