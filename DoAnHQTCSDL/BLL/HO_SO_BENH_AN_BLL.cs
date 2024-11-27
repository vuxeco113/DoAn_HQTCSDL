using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HO_SO_BENH_AN_BLL
    {
        private HO_SO_BENH_AN_DAL hoSoBenhAnDAL;

        public HO_SO_BENH_AN_BLL()
        {
            hoSoBenhAnDAL = new HO_SO_BENH_AN_DAL();
        }

        // Lấy tất cả hồ sơ bệnh án
        public DataTable GetHoSoBenhAn()
        {
            return hoSoBenhAnDAL.GetAllHoSoBenhAn();
        }

        // Thêm hồ sơ bệnh án
        public void AddHoSoBenhAn(HO_SO_BENH_AN_DTO hoSoBenhAn)
        {
            hoSoBenhAnDAL.AddHoSoBenhAn(hoSoBenhAn);
        }

        // Sửa hồ sơ bệnh án
        public void UpdateHoSoBenhAn(HO_SO_BENH_AN_DTO hoSoBenhAn)
        {
            hoSoBenhAnDAL.UpdateHoSoBenhAn(hoSoBenhAn);
        }

        // Xóa hồ sơ bệnh án
        public void DeleteHoSoBenhAn(string maHoSo)
        {
            hoSoBenhAnDAL.DeleteHoSoBenhAn(maHoSo);
        }

        // Lấy tổng số hồ sơ bệnh án
        public int GetTotalHoSoBenhAn()
        {
            return hoSoBenhAnDAL.GetTotalHoSoBenhAn();
        }

        // Lấy hồ sơ bệnh án theo mã hồ sơ
        public DataTable GetHoSoByMaHoSo(string maHoSo)
        {
            try
            {
                return hoSoBenhAnDAL.GetHoSoByMaHoSo(maHoSo);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy hồ sơ bệnh án: " + ex.Message);
            }
        }

        // Lấy hồ sơ bệnh án theo mã bệnh nhân
        public DataTable GetHoSoBenhAnByMaBenhNhan(string maBenhNhan)
        {
            try
            {
                return hoSoBenhAnDAL.GetHoSoBenhAnByMaBenhNhan(maBenhNhan);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu hồ sơ bệnh án theo mã bệnh nhân: " + ex.Message);
            }
        }

        // Lấy hồ sơ bệnh án theo mã bác sĩ
        public DataTable GetHoSoBenhAnByMaBacSi(string maBacSi)
        {
            try
            {
                return hoSoBenhAnDAL.GetHoSoBenhAnByMaBaSi(maBacSi);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu hồ sơ bệnh án theo mã bệnh nhân: " + ex.Message);
            }
        }

        // Lấy hồ sơ bệnh án theo ngày lập
        public DataTable GetHoSoBenhAnByNgayLap(DateTime ngayLap)
        {
            try
            {
                return hoSoBenhAnDAL.GetHoSoBenhAnByNgayLap(ngayLap);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu hồ sơ bệnh án theo ngày lập: " + ex.Message);
            }
        }

        // Lấy hồ sơ bệnh án theo khoảng thời gian
        public DataTable GetHoSoBenhAnByKhoangThoiGian(DateTime tuNgay, DateTime denNgay)
        {
            if (tuNgay > denNgay)
            {
                throw new ArgumentException("Ngày bắt đầu không được lớn hơn ngày kết thúc.");
            }

            try
            {
                return hoSoBenhAnDAL.GetHoSoBenhAnByKhoangThoiGian(tuNgay, denNgay);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu hồ sơ bệnh án theo khoảng thời gian: " + ex.Message);
            }
        }

        public DataTable GetThongTinChiTietByMaBenhNhan(string maBenhNhan)
        {
            try
            {
                return hoSoBenhAnDAL.GetThongTinChiTietByMaBenhNhan(maBenhNhan);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin chi tiết từ BLL: " + ex.Message);
            }
        }


    }
}
