using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TOA_THUOC_DTO
    {
        public string MaToa { get; set; }
        public string NgayKetToa { get; set; }
        public int SoNgayDung { get; set; }
        public string NgayKetThuc { get; set; }
        public int SoLoaiThuoc { get; set; }
        public string MaBacSi { get; set; }
        public TOA_THUOC_DTO() { }
        public TOA_THUOC_DTO(string maToa, string ngayKetToa, int soNgayDung, string ngayKetThuc, int soLoaiThuoc, string maBacSi)
        {
            MaToa = maToa;
            NgayKetToa = ngayKetToa;
            SoNgayDung = soNgayDung;
            NgayKetThuc = ngayKetThuc;
            SoLoaiThuoc = soLoaiThuoc;
            MaBacSi = maBacSi;
        }
    }
}
