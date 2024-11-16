using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TOA_THUOC_BLL
    {
        public TOA_THUOC_DAL ttDAL { get; set; }
        public TOA_THUOC_BLL()
        {
            ttDAL= new TOA_THUOC_DAL();

        }
        public List<TOA_THUOC_DTO>get_all()
        {
            return ttDAL.get_all();
        }
    }
}
