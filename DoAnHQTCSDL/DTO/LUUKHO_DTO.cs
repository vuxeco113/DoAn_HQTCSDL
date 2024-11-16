using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LUUKHO_DTO
    {
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public int SLTon { get; set; }
        public string DonVi { get; set; }
        public string NgayNhap { get; set; }
        public string HanSuDung { get; set; }
        public LUUKHO_DTO() { }
        public LUUKHO_DTO(string maThuoc, string tenThuoc, int sLTon, string donVi, string ngayNhap, string hanSuDung)
        {
            MaThuoc = maThuoc;
            TenThuoc = tenThuoc;
            SLTon = sLTon;
            DonVi = donVi;
            NgayNhap = ngayNhap;
            HanSuDung = hanSuDung;
        }
    }
}
