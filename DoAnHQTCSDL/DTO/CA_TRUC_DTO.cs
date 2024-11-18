using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CA_TRUC_DTO
    {
        public string MaCaTruc { get; set; }  // Mã Ca Trực (Primary Key)
        public string ThoiGianCa { get; set; }  // Thời Gian Ca Trực (Ví dụ: "08:00 - 12:00")

        // Constructor không tham số
        public CA_TRUC_DTO() { }

        // Constructor có tham số
        public CA_TRUC_DTO(string maCaTruc, string thoiGianCa)
        {
            MaCaTruc = maCaTruc;
            ThoiGianCa = thoiGianCa;
        }
    }
}
