using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KHOA_DTO
    {
        public string MaKhoa { get; set; }  // Mã Khoa (Primary Key)
        public string TenKhoa { get; set; } // Tên Khoa

        // Constructor không tham số
        public KHOA_DTO() { }

        // Constructor có tham số
        public KHOA_DTO(string maKhoa, string tenKhoa)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
        }
    }
}
