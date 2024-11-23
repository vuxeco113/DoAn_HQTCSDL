using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LICH_TRUC_DTO
    {
        public string MaLichTruc { get; set; }  // Mã Lịch Trực (Primary Key)
        public string MaBacSi { get; set; }     // Mã Bác Sĩ (Foreign Key liên kết với bảng BACSI)
        public string TenBacSi { get; set; }
        public DateTime NgayTruc { get; set; }  // Ngày Trực
        public string MaCaTruc { get; set; }    // Mã Ca Trực (Foreign Key liên kết với bảng CATRUC)

        // Constructor không tham số
        public LICH_TRUC_DTO() { }

        // Constructor có tham số
        public LICH_TRUC_DTO(string maLichTruc, string maBacSi, DateTime ngayTruc, string maCaTruc)
        {
            MaLichTruc = maLichTruc;
            MaBacSi = maBacSi;
            NgayTruc = ngayTruc;
            MaCaTruc = maCaTruc;
        }
    }
}
