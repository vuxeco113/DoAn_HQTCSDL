using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CHI_TIET_TOA_THUOC_DTO
    {
        public string MaToa { get; set; }
        public string MaThuoc { get; set; }
        public int SL { get; set; }
        public string CachDung { get; set; }
        public CHI_TIET_TOA_THUOC_DTO() { }
        public CHI_TIET_TOA_THUOC_DTO(string maToa, string maThuoc, int sL, string cachDung)
        {
            MaToa = maToa;
            MaThuoc = maThuoc;
            SL = sL;
            CachDung = cachDung;
        }
    }
}
