using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CHITIET_PN_THUOC_DTO
    {
        public string MaPN { get; set; }
        public string MaThuoc { get; set; }
        public int SL { get; set; }
        public float Gia { get; set; }
        public CHITIET_PN_THUOC_DTO() { }
        public CHITIET_PN_THUOC_DTO(string maPN, string maThuoc, int sL, float gia)
        {
            MaPN = maPN;
            MaThuoc = maThuoc;
            SL = sL;
            Gia = gia;
        }
        public float ThanhTien()
        {
            return SL * Gia;
        }
    }
}
