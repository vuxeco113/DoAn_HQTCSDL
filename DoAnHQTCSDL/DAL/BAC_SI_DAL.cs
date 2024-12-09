using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BAC_SI_DAL
    {
        private dbContext dbContext;

        public BAC_SI_DAL()
        {
            dbContext = new dbContext();
        }

        // Lấy tất cả dữ liệu từ bảng BACSI
        public List<BAC_SI_DTO> GetAll()
        {
            List<BAC_SI_DTO> ds = new List<BAC_SI_DTO>();

            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                string sql = "SELECT * FROM BACSI";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BAC_SI_DTO tmp = new BAC_SI_DTO(
                            reader["MaBacSi"].ToString(),
                            reader["HoTen"].ToString(),
                            reader["MaKhoa"].ToString(),
                            reader["SoDienThoai"].ToString(),
                            int.Parse(reader["SoCaTruc"].ToString()),
                            reader["MatKhau"].ToString(),
                            reader["ChucVu"].ToString()
                        );
                        ds.Add(tmp);
                    }
                }
            }

            return ds;
        }

        // Thêm bác sĩ
        public bool Them_BacSi(BAC_SI_DTO tmp)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                string sql = @"
                INSERT INTO BACSI (MaBacSi, HoTen, MaKhoa, SoDienThoai, SoCaTruc, MatKhau, ChucVu) 
                VALUES (@MaBacSi, @HoTen, @MaKhoa, @SoDienThoai, @SoCaTruc, @MatKhau, @ChucVu)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaBacSi", tmp.MaBacSi);
                cmd.Parameters.AddWithValue("@HoTen", tmp.HoTen);
                cmd.Parameters.AddWithValue("@MaKhoa", tmp.MaKhoa);
                cmd.Parameters.AddWithValue("@SoDienThoai", tmp.SoDienThoai);
                cmd.Parameters.AddWithValue("@SoCaTruc", tmp.SoCaTruc);
                cmd.Parameters.AddWithValue("@MatKhau", tmp.MatKhau);
                cmd.Parameters.AddWithValue("@ChucVu", tmp.ChucVu);

                conn.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        // Sửa thông tin bác sĩ
        public bool Sua_BacSi(BAC_SI_DTO tmp)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                string sql = @"
                UPDATE BACSI 
                SET HoTen = @HoTen, MaKhoa = @MaKhoa, SoDienThoai = @SoDienThoai, SoCaTruc = @SoCaTruc, MatKhau = @MatKhau, ChucVu = @ChucVu 
                WHERE MaBacSi = @MaBacSi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaBacSi", tmp.MaBacSi);
                cmd.Parameters.AddWithValue("@HoTen", tmp.HoTen);
                cmd.Parameters.AddWithValue("@MaKhoa", tmp.MaKhoa);
                cmd.Parameters.AddWithValue("@SoDienThoai", tmp.SoDienThoai);
                cmd.Parameters.AddWithValue("@SoCaTruc", tmp.SoCaTruc);
                cmd.Parameters.AddWithValue("@MatKhau", tmp.MatKhau);
                cmd.Parameters.AddWithValue("@ChucVu", tmp.ChucVu);

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        // Xóa bác sĩ
        public bool Xoa_BacSi(string maBacSi)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                string sql = "DELETE FROM BACSI WHERE MaBacSi = @MaBacSi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaBacSi", maBacSi);

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
        // Load dữ liệu từ bảng Khoa
        public List<KHOA_DTO> LoadKhoa()
        {
            List<KHOA_DTO> khoaList = new List<KHOA_DTO>();
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                string sql = "SELECT MaKhoa, TenKhoa FROM KHOA";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KHOA_DTO khoa = new KHOA_DTO
                        {
                            MaKhoa = reader["MaKhoa"].ToString(),
                            TenKhoa = reader["TenKhoa"].ToString()
                        };
                        khoaList.Add(khoa);
                    }
                }
            }
            return khoaList;
        }
    }
}
