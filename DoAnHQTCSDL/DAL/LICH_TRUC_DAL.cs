using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LICH_TRUC_DAL
    {
        dbContext dbContext = new dbContext();

        // Lấy danh sách tất cả lịch trực
        public DataTable GetAllLichTruc()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                string query = @"
                SELECT 
                    lt.MaBacSi,
                    bs.HoTen AS TenBacSi,
                    lt.NgayTruc,
                    ct.ThoiGianCa,
                    ct.MaCaTruc,
                    k.TenKhoa AS Khoa
                FROM LichTruc lt
                JOIN BacSi bs ON lt.MaBacSi = bs.MaBacSi
                JOIN CaTruc ct ON lt.MaCaTruc = ct.MaCaTruc
                JOIN Khoa k ON bs.MaKhoa = k.MaKhoa";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }


        // Thêm lịch trực
        public bool ThemLichTruc(LICH_TRUC_DTO lichTruc)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("PROC_THEMLICHTRUC", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaBacSi", lichTruc.MaBacSi);
                    cmd.Parameters.AddWithValue("@NgayTruc", lichTruc.NgayTruc);
                    cmd.Parameters.AddWithValue("@MaCaTruc", lichTruc.MaCaTruc);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true; // Chèn thành công
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Lỗi SQL: " + ex.Message, ex);
                    }
                }
            }


        }

        // Sửa lịch trực
        public bool SuaLichTruc(LICH_TRUC_DTO lichTruc)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                string query = @"
            UPDATE LichTruc 
            SET MaCaTruc = @MaCaTruc 
            WHERE MaBacSi = @MaBacSi 
              AND NgayTruc = @NgayTruc";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaBacSi", lichTruc.MaBacSi);
                    cmd.Parameters.AddWithValue("@NgayTruc", lichTruc.NgayTruc);
                    cmd.Parameters.AddWithValue("@MaCaTruc", lichTruc.MaCaTruc);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }

        }

        // Xóa lịch trực
        public bool XoaLichTruc(string maBacSi, DateTime ngayTruc, string maCaTruc)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                string query = @"
            DELETE FROM LichTruc 
            WHERE MaBacSi = @MaBacSi 
              AND NgayTruc = @NgayTruc 
              AND MaCaTruc = @MaCaTruc";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaBacSi", maBacSi);
                    cmd.Parameters.AddWithValue("@NgayTruc", ngayTruc);
                    cmd.Parameters.AddWithValue("@MaCaTruc", maCaTruc);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }


        }

        // Đếm số lượng lịch trực trong ngày
        public int DemSoMaLichTrongNgay(DateTime ngay)
        {
            int count = 0;

            string query = "SELECT COUNT(*) FROM LICHTRUC WHERE CONVERT(DATE, NgayTruc) = @Ngay";
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ngay", ngay.Date);

                    count = (int)cmd.ExecuteScalar();
                }
            }
            return count;
        }
        public DataTable FilterByName(string name)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                string query = @"
            SELECT 
                lt.MaBacSi,
                bs.HoTen AS TenBacSi,
                lt.NgayTruc,
                ct.ThoiGianCa,
                ct.MaCaTruc,
                k.TenKhoa AS Khoa
            FROM LichTruc lt
            JOIN BacSi bs ON lt.MaBacSi = bs.MaBacSi
            JOIN CaTruc ct ON lt.MaCaTruc = ct.MaCaTruc
            JOIN Khoa k ON bs.MaKhoa = k.MaKhoa
            WHERE bs.MaBacSi = @Name";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable FilterByDate(DateTime date)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                string query = @"
            SELECT 
                lt.MaBacSi,
                bs.HoTen AS TenBacSi,
                lt.NgayTruc,
                ct.ThoiGianCa,
                ct.MaCaTruc,
                k.TenKhoa AS Khoa
            FROM LichTruc lt
            JOIN BacSi bs ON lt.MaBacSi = bs.MaBacSi
            JOIN CaTruc ct ON lt.MaCaTruc = ct.MaCaTruc
            JOIN Khoa k ON bs.MaKhoa = k.MaKhoa
            WHERE lt.NgayTruc = @Date";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", date);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable FilterByDateAndShift(DateTime date, string shift)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                string query = @"
            SELECT 
                lt.MaBacSi,
                bs.HoTen AS TenBacSi,
                lt.NgayTruc,
                lt.MaCaTruc,
                ct.ThoiGianCa,
                ct.MaCaTruc,
                k.TenKhoa AS Khoa
            FROM LichTruc lt
            JOIN BacSi bs ON lt.MaBacSi = bs.MaBacSi
            JOIN CaTruc ct ON lt.MaCaTruc = ct.MaCaTruc
            JOIN Khoa k ON bs.MaKhoa = k.MaKhoa
            WHERE lt.NgayTruc = @Date AND ct.MaCaTruc = @Shift";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Shift", shift);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public void PhanLichTrucTuDong(DateTime ngayTruc)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("PROC_PHANLICHTRUCTUDONG", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NgayTruc", ngayTruc);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Lỗi SQL: " + ex.Message, ex);
                    }
                }
            }
        }
        public DataTable KiemTraCaTrucTrongTrongNgay(DateTime ngayTruc)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("PROC_KIEMTRACATRUCTRONGTRONGNGAY", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NgayTruc", ngayTruc);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        // Gọi function FUNC_LAYLICHTRUCCUABACSI
        public DataTable LayLichTrucCuaBacSi(string maBacSi, DateTime ngayTruc)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.FUNC_LAYLICHTRUCCUABACSI(@MaBacSi, @NgayTruc)", conn))
                {
                    cmd.Parameters.AddWithValue("@MaBacSi", maBacSi);
                    cmd.Parameters.AddWithValue("@NgayTruc", ngayTruc);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Gọi function FUNC_LAYDANHSACHBACSI
        public DataTable LayDanhSachBacSi(DateTime ngayTruc)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.FUNC_LAYDANHSACHBACSI(@NgayTruc)", conn))
                {
                    cmd.Parameters.AddWithValue("@NgayTruc", ngayTruc);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Gọi function FUNC_LAYCATRUCCHUADUOCPHANCONG_TRONGNGAY
        public DataTable LayCaTrucChuaDuocPhanCongTrongNgay(DateTime ngayTruc)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.FUNC_LAYCATRUCCHUADUOCPHANCONG_TRONGNGAY(@NgayTruc)", conn))
                {
                    cmd.Parameters.AddWithValue("@NgayTruc", ngayTruc);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Phương thức để lấy danh sách lịch trực bác sĩ trong khoảng ngày
        public DataTable LayDanhSachLichTruc(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                string query = @"
                SELECT b.MaBacSi, b.HoTen, l.NgayTruc, l.MaCaTruc
                FROM BACSI b
                JOIN LICHTRUC l ON b.MaBacSi = l.MaBacSi
                WHERE l.NgayTruc BETWEEN @StartDate AND @EndDate";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        // Phương thức để lấy bác sĩ cùng ca trực
        public DataTable LayBacSiCungCa(DateTime ngayTruc, string maCaTruc)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                string query = @"
                SELECT b.MaBacSi, b.HoTen, l.NgayTruc, l.MaCaTruc
                FROM BACSI b
                JOIN LICHTRUC l ON b.MaBacSi = l.MaBacSi
                WHERE l.NgayTruc = @NgayTruc AND l.MaCaTruc = @MaCaTruc";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NgayTruc", ngayTruc);
                    cmd.Parameters.AddWithValue("@MaCaTruc", maCaTruc);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

    }
}
