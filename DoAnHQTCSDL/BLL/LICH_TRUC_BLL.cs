using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class LICH_TRUC_BLL
    {
        private LICH_TRUC_DAL lichTrucDAL = new LICH_TRUC_DAL();

        // Lấy danh sách tất cả lịch trực
        public DataTable GetAllLichTruc()
        {
            return lichTrucDAL.GetAllLichTruc();
        }

        // Thêm một lịch trực mới
        public bool AddLichTruc(LICH_TRUC_DTO lichTruc)
        {
            try
            {
                return lichTrucDAL.ThemLichTruc(lichTruc);
            }
            catch (ArgumentException ex)
            {
                // Xử lý lỗi đặc biệt, chẳng hạn như trùng khóa chính
                throw new Exception("Lỗi nghiệp vụ: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi chung
                throw new Exception("Lỗi không xác định: " + ex.Message);
            }

        }

        public bool UpdateLichTruc(LICH_TRUC_DTO lichTruc)
        {
            try
            {
                return lichTrucDAL.SuaLichTruc(lichTruc);
            }
            catch (SqlException ex)
            {
                // Xử lý ngoại lệ SQL
                throw new Exception("Lỗi SQL: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác
                throw new Exception("Lỗi không xác định: " + ex.Message, ex);
            }

        }

        public bool DeleteLichTruc(string maBacSi, DateTime ngayTruc, string maCaTruc)
        {
            try
            {
                return lichTrucDAL.XoaLichTruc(maBacSi, ngayTruc, maCaTruc);
            }
            catch (SqlException ex)
            {
                // Xử lý ngoại lệ SQL
                throw new Exception("Lỗi SQL: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác
                throw new Exception("Lỗi không xác định: " + ex.Message, ex);
            }

        }
        public DataTable FilterByName(string name)
        {
            try
            {
                return lichTrucDAL.FilterByName(name);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi SQL: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi không xác định: " + ex.Message, ex);
            }
        }

        public DataTable FilterByDate(DateTime date)
        {
            try
            {
                return lichTrucDAL.FilterByDate(date);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi SQL: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi không xác định: " + ex.Message, ex);
            }
        }

        public DataTable FilterByDateAndShift(DateTime date, string shift)
        {
            try
            {
                return lichTrucDAL.FilterByDateAndShift(date, shift);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi SQL: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi không xác định: " + ex.Message, ex);
            }
        }

        public void PhanLichTrucTuDong(DateTime ngayTruc)
        {
            try
            {
                lichTrucDAL.PhanLichTrucTuDong(ngayTruc);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi phân lịch trực tự động: " + ex.Message, ex);
            }
        }

        public DataTable KiemTraCaTrucTrongTrongNgay(DateTime ngayTruc)
        {
            try
            {
                return lichTrucDAL.KiemTraCaTrucTrongTrongNgay(ngayTruc);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kiểm tra ca trực trống: " + ex.Message, ex);
            }
        }

        public DataTable LayLichTrucCuaBacSi(string maBacSi, DateTime ngayTruc)
        {
            try
            {
                return lichTrucDAL.LayLichTrucCuaBacSi(maBacSi, ngayTruc);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy lịch trực của bác sĩ: " + ex.Message, ex);
            }
        }

        public DataTable LayDanhSachBacSi(DateTime ngayTruc)
        {
            try
            {
                return lichTrucDAL.LayDanhSachBacSi(ngayTruc);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy danh sách bác sĩ: " + ex.Message, ex);
            }
        }

        public DataTable LayCaTrucChuaDuocPhanCongTrongNgay(DateTime ngayTruc)
        {
            try
            {
                return lichTrucDAL.LayCaTrucChuaDuocPhanCongTrongNgay(ngayTruc);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy ca trực chưa được phân công trong ngày: " + ex.Message, ex);
            }
        }

        public DataTable LayDanhSachLichTruc(DateTime startDate, DateTime endDate)
        {
            try
            {
                return lichTrucDAL.LayDanhSachLichTruc(startDate, endDate);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy danh sách lịch trực bác sĩ: " + ex.Message, ex);
            }
        }

        public DataTable LayBacSiCungCa(DateTime ngayTruc, string maCaTruc)
        {
            try
            {
                return lichTrucDAL.LayBacSiCungCa(ngayTruc, maCaTruc);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy bác sĩ cùng ca trực: " + ex.Message, ex);
            }
        }


    }
}
