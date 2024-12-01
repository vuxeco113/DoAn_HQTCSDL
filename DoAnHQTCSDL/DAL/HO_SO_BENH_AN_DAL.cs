using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.Common;
using Utility;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HO_SO_BENH_AN_DAL
    {
        private DBconnection dbConnection;
        public HO_SO_BENH_AN_DAL()
        {
            dbConnection = new DBconnection();
        }

        // Lấy danh sách hồ sơ bệnh án
        public DataTable GetAllHoSoBenhAn()
        {
            string query = "SELECT * FROM HOSOBENHAN";
            return dbConnection.GetDataTable(query);
        }
        // Thêm hồ sơ bệnh án mới
        public void AddHoSoBenhAn(HO_SO_BENH_AN_DTO hoSoBenhAn)
        {
            string query = "EXEC PROC_THEMHOSOBENHAN @MaHoSo, @MaBenhNhan, @NgayLapHoSo, @MaBacSi, @NoiDungHoSo";
            var parameters = new List<SqlParameter>
        {
            new SqlParameter("@MaHoSo", SqlDbType.Char) { Value = hoSoBenhAn.MaHoSo },
            new SqlParameter("@MaBenhNhan", SqlDbType.Char) { Value = hoSoBenhAn.MaBenhNhan },
            new SqlParameter("@NgayLapHoSo", SqlDbType.Date) { Value = hoSoBenhAn.NgayLapHoSo },
            new SqlParameter("@MaBacSi", SqlDbType.Char) { Value = hoSoBenhAn.MaBacSi },
            new SqlParameter("@NoiDungHoSo", SqlDbType.NVarChar) { Value = hoSoBenhAn.NoiDungHoSo }
        };
            dbConnection.ExecuteQuery(query, parameters);
        }

        // Sửa hồ sơ bệnh án
        public void UpdateHoSoBenhAn(HO_SO_BENH_AN_DTO hoSoBenhAn)
        {
            string query = "EXEC PROC_CAPNHATHOSOBENHAN @MaHoSo, @MaBenhNhan, @MaBacSi, @NoiDungHoSo";
            var parameters = new List<SqlParameter>
        {
            new SqlParameter("@MaHoSo", SqlDbType.Char) { Value = hoSoBenhAn.MaHoSo },
            new SqlParameter("@MaBenhNhan", SqlDbType.Char) { Value = hoSoBenhAn.MaBenhNhan },
            new SqlParameter("@MaBacSi", SqlDbType.Char) { Value = hoSoBenhAn.MaBacSi },
            new SqlParameter("@NoiDungHoSo", SqlDbType.NVarChar) { Value = hoSoBenhAn.NoiDungHoSo }
        };
            dbConnection.ExecuteQuery(query, parameters);
        }

        //Xóa hồ sơ bệnh án
        public void DeleteHoSoBenhAn(string maHoSo)
        {
            string query = "EXEC PROC_XOAHOSOBENHAN @MaHoSo";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaHoSo", SqlDbType.Char) { Value = maHoSo }
            };
            dbConnection.ExecuteQuery(query, parameters);
        }

        //Tổng hồ sơ
        public int GetTotalHoSoBenhAn()
        {
            string query = "SELECT dbo.FUNC_LAY_TONG_HO_SO()";
            object result = dbConnection.ExecuteScalar(query);

            // Kiểm tra và chuyển đổi giá trị trả về
            if (result != null && int.TryParse(result.ToString(), out int total))
            {
                return total;
            }

            // Nếu không lấy được kết quả, trả về giá trị mặc định
            return 0;
        }

        // Lấy nội dung hồ sơ bệnh án theo mã hồ sơ
        public DataTable GetHoSoByMaHoSo(string maHoSo)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaHoSo", maHoSo)
            };
            // Gọi hàm FUNC_LAY_HO_SO_THEO_MA_HO_SO
            return dbConnection.GetDataTable("SELECT * FROM dbo.FUNC_LAY_HO_SO_THEO_MA_HO_SO(@MaHoSo)", parameters);

        }

        // Lấy hồ sơ bệnh án theo mã bệnh nhân
        public DataTable GetHoSoBenhAnByMaBenhNhan(string maBenhNhan)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaBenhNhan", maBenhNhan)
            };
            // Gọi thủ tục PROC_LAYDANHSACHHOSOBENHAN
            return dbConnection.GetDataTable("EXEC PROC_LAYDANHSACHHOSOBENHAN @MaBenhNhan", parameters);
        }

        // Lấy hồ sơ bệnh án theo mã bác sĩ
        public DataTable GetHoSoBenhAnByMaBaSi(string maBacSi)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaBacSi", maBacSi)
            };
            // Gọi hàm FUNC_KIEM_TRA_HO_SO_CUNG_BAC_SI
            return dbConnection.GetDataTable("SELECT * FROM dbo.FUNC_KIEM_TRA_HO_SO_CUNG_BAC_SI(@MaBacSi)", parameters);

        }

        // Lấy hồ sơ bệnh án theo ngày lập
        public DataTable GetHoSoBenhAnByNgayLap(DateTime ngayLap)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@NgayLapHoSo", ngayLap)
            };
            // Gọi thủ tục PROC_LAYDANHSACHHOSOTHEONGAY
            return dbConnection.GetDataTable("EXEC PROC_LAYDANHSACHHOSOTHEONGAY @NgayLapHoSo", parameters);
        }

        // Lấy hồ sơ bệnh án theo khoảng thời gian
        public DataTable GetHoSoBenhAnByKhoangThoiGian(DateTime tuNgay, DateTime denNgay)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@TuNgay", tuNgay),
                new SqlParameter("@DenNgay", denNgay)
            };
            // Gọi hàm FUNC_LAY_HO_SO_BENH_AN_THEO_KHOANG_THOI_GIAN
            return dbConnection.GetDataTable("SELECT * FROM dbo.FUNC_LAY_HO_SO_BENH_AN_THEO_KHOANG_THOI_GIAN(@TuNgay, @DenNgay)", parameters);

        }

        // Lấy thông tin chi tiết hồ sơ bệnh án theo mã bệnh nhân
        public DataTable GetThongTinChiTietByMaBenhNhan(string maBenhNhan)
        {
            string query = @"
                SELECT PK.MaPhieuKham, PK.NgayKham, BN.HoTen AS TenBenhNhan, BS.HoTen AS TenBacSi
                FROM PHIEUKHAM PK
                INNER JOIN BENHNHAN BN ON PK.MaBenhNhan = BN.MaBenhNhan
                INNER JOIN BACSI BS ON PK.MaBacSi = BS.MaBacSi
                WHERE BN.MaBenhNhan = @MaBenhNhan";

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaBenhNhan", maBenhNhan)
            };

            return dbConnection.GetDataTable(query, parameters);
        }
    }
}
