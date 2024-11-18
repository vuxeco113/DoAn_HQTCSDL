using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CA_TRUC_BLL
    {
        CA_TRUC_DAL catruc = new CA_TRUC_DAL();
        public List<CA_TRUC_DTO> get_all()
        {
            return catruc.get_all();
        }
    }
}
