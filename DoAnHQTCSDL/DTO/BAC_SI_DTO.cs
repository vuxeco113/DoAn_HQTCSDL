using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BAC_SI_DTO
    {
        public string MaBacSi { get; set; }     // Mã Bác Sĩ (Primary Key)
        public string HoTen { get; set; }        // Họ và Tên 
        public string MaKhoa { get; set; }       // Mã Khoa (Foreign Key liên kết với bảng KHOA)
        public string SoDienThoai { get; set; }  // Số Điện Thoại của Bác Sĩ
        public int SoCaTruc { get; set; }        // Số Ca Trực tối đa có thể làm
        public string MatKhau { get; set; }      // Mật Khẩu để đăng nhập hệ thống
        public string ChucVu { get; set; }       // Chức Vụ của bác sĩ

        // Constructor không tham số
        public BAC_SI_DTO() { }

        // Constructor có tham số
        public BAC_SI_DTO(string maBacSi, string hoTen, string maKhoa, string soDienThoai, int soCaTruc, string matKhau, string chucVu)
        {
            MaBacSi = maBacSi;
            HoTen = hoTen;
            MaKhoa = maKhoa;
            SoDienThoai = soDienThoai;
            SoCaTruc = soCaTruc;
            MatKhau = matKhau;
            ChucVu = chucVu;
        }
    }
}
