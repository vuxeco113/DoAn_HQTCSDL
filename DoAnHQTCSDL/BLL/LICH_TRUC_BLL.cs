using DTO;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class LICH_TRUC_BLL
    {
        private LICH_TRUC_DAL lichTrucDAL = new LICH_TRUC_DAL();

        // Lấy danh sách tất cả lịch trực
        public List<LICH_TRUC_DTO> LayDanhSachLichTruc()
        {
            return lichTrucDAL.GetAll();
        }

        // Thêm một lịch trực mới
        public bool ThemLichTruc(LICH_TRUC_DTO lichTruc)
        {
            // Kiểm tra dữ liệu trước khi thêm
            if (string.IsNullOrEmpty(lichTruc.MaLichTruc) ||
                string.IsNullOrEmpty(lichTruc.MaBacSi) ||
                string.IsNullOrEmpty(lichTruc.MaCaTruc))
            {
                return false; // Dữ liệu không hợp lệ
            }

            // Gọi DAL để thêm
            return lichTrucDAL.ThemLichTruc(lichTruc);
        }

        // Sửa thông tin lịch trực
        public bool SuaLichTruc(LICH_TRUC_DTO lichTruc)
        {
            // Kiểm tra dữ liệu trước khi sửa
            if (string.IsNullOrEmpty(lichTruc.MaLichTruc))
            {
                return false; // Không có mã lịch trực để sửa
            }

            // Gọi DAL để sửa
            return lichTrucDAL.SuaLichTruc(lichTruc);
        }

        // Xóa một lịch trực
        public bool XoaLichTruc(string maLichTruc)
        {
            // Kiểm tra dữ liệu trước khi xóa
            if (string.IsNullOrEmpty(maLichTruc))
            {
                return false; // Không có mã lịch trực để xóa
            }

            // Tạo DTO với mã lịch trực cần xóa
            LICH_TRUC_DTO lichTruc = new LICH_TRUC_DTO
            {
                MaLichTruc = maLichTruc
            };

            // Gọi DAL để xóa
            return lichTrucDAL.XoaLichTruc(lichTruc);
        }

        // Đếm số lịch trực trong ngày
        public int DemSoLichTrongNgay(DateTime ngay)
        {
            return lichTrucDAL.DemSoMaLichTrongNgay(ngay);
        }

        // Kiểm tra lịch trực của bác sĩ trong ngày
        public bool KiemTraLichTrucBacSi(string maBacSi, DateTime ngay)
        {
            List<LICH_TRUC_DTO> danhSach = lichTrucDAL.GetAll();

            foreach (var lich in danhSach)
            {
                if (lich.MaBacSi == maBacSi && lich.NgayTruc.Date == ngay.Date)
                {
                    return true; // Bác sĩ này đã có lịch trực trong ngày
                }
            }
            return false; // Không có lịch trực cho bác sĩ này trong ngày
        }
    }
}
