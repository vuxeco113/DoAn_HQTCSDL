using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class THANH_TOAN_DTO
    {
        public string MaThanhToan { get; set; }
        public string MaPhieuKham { get; set; }
        public string MaRaVien { get; set; }
        public float SoTien { get; set; }
        public string NgayThanhToan { get;set; }
        public THANH_TOAN_DTO() { }
        public THANH_TOAN_DTO(string maThanhToan, string maPhieuKham, string maRaVien, float soTien, string ngayThanhToan)
        {
            MaThanhToan = maThanhToan;
            MaPhieuKham = maPhieuKham;
            MaRaVien = maRaVien;
            SoTien = soTien;
            NgayThanhToan = ngayThanhToan;
        }
    }
}
