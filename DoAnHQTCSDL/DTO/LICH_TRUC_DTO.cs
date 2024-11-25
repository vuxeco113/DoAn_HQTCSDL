using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LICH_TRUC_DTO
    {
        public string MaBacSi { get; set; }     // Mã Bác Sĩ (Foreign Key liên kết với bảng BACSI)
        public DateTime NgayTruc { get; set; }  // Ngày Trực
        public string MaCaTruc { get; set; }    // Mã Ca Trực (Foreign Key liên kết với bảng CATRUC)

        // Constructor không tham số
        public LICH_TRUC_DTO() { }

        // Constructor có tham số

    }
}
