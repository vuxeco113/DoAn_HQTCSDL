using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PHIEU_NHAP_THUOC_DTO
    {
        public string MaPN { get; set; }
        public string MaNCC { get; set; }
        public string NgayNhap { get; set; }
        public float ThanhTien { get; set; }
        public List<CHITIET_PN_THUOC_DTO> ChITIET_PN { get; set; }
        public PHIEU_NHAP_THUOC_DTO() { }
        public PHIEU_NHAP_THUOC_DTO(string maPN, string maNCC, string ngayNhap, float thanhTien)
        {
            MaPN = maPN;
            MaNCC = maNCC;
            NgayNhap = ngayNhap;
            ThanhTien = thanhTien;
        }
    }
}
