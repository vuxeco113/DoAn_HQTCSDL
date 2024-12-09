using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UlinityTool
{
    public class DBConnect
    {
        SqlConnection conn;
        string connectionString = ("Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=QLBV2;Integrated Security=True");

        public SqlConnection Conn { get => conn; set => conn = value; }

        public DBConnect()
        {
            Conn = new SqlConnection(connectionString);
        }

        public void OpenConnect()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
        }

        public void CloseConnect()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        public int ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
        {
            OpenConnect();

            SqlCommand cmd = new SqlCommand(sql, Conn)
            {
                CommandType = sql.StartsWith("sp_") ? CommandType.StoredProcedure : CommandType.Text
            };

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            int result = cmd.ExecuteNonQuery();
            CloseConnect();
            return result;
        }

        public object ExecuteScalar(string sql, SqlParameter[] parameters = null)
        {
            OpenConnect();

            SqlCommand cmd = new SqlCommand(sql, Conn)
            {
                CommandType = sql.StartsWith("sp_") ? CommandType.StoredProcedure : CommandType.Text
            };

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            object result = cmd.ExecuteScalar();
            CloseConnect();
            return result;
        }

        public DataTable GetDataTable(string query, SqlParameter[] parameters, CommandType commandType)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = commandType;

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }


        public bool NhapVien(string maNhapVien, string maBenhNhan, DateTime ngayNhapVien, string maBacSi, string maPhong, string lyDoNhapVien)
        {
            DBConnect db = new DBConnect();

            string sql = "sp_NhapVienBenhNhan";
            SqlParameter[] parameters = {
                new SqlParameter("@MaNhapVien", maNhapVien),
                new SqlParameter("@MaBenhNhan", maBenhNhan),
                new SqlParameter("@NgayNhapVien", ngayNhapVien),
                new SqlParameter("@MaBacSi", maBacSi),
                new SqlParameter("@MaPhong", maPhong),
                new SqlParameter("@LyDoNhapVien", lyDoNhapVien)
                };

            return db.ExecuteNonQuery(sql, parameters) > 0;
        }

        public bool XuatVien(string maRaVien, string maNhapVien, string maBenhNhan, DateTime ngayRaVien, string tinhTrangRaVien, out int soNgayNamVien)
        {
            DBConnect db = new DBConnect();
            soNgayNamVien = 0;

            string sql = "sp_XuatVienBenhNhan";
            SqlParameter[] parameters = {
                new SqlParameter("@MaRaVien", maRaVien),
                new SqlParameter("@MaNhapVien", maNhapVien),
                new SqlParameter("@MaBenhNhan", maBenhNhan),
                new SqlParameter("@NgayRaVien", ngayRaVien),
                new SqlParameter("@TinhTrangRaVien", tinhTrangRaVien),
                new SqlParameter("@SoNgayNamVien", SqlDbType.Int) { Direction = ParameterDirection.Output }
                };

            bool result = db.ExecuteNonQuery(sql, parameters) > 0;

            if (parameters[6].Value != DBNull.Value)
            {
                soNgayNamVien = Convert.ToInt32(parameters[6].Value);
            }

            return result;
        }

        public DataTable LayLichSuNhapVien(string maBenhNhan)
        {
            DBConnect db = new DBConnect();

            string sql = "PROC_LICHSUNHAPVIEN";
            SqlParameter[] parameters = {
        new SqlParameter("@MaBenhNhan", SqlDbType.Char) { Value = maBenhNhan }
    };

            return db.GetDataTable(sql, parameters, CommandType.StoredProcedure);
        }

        public bool KiemTraBaoHiem(string maBenhNhan)
        {
            DBConnect db = new DBConnect();

            string sql = "SELECT dbo.FUNC_HAM_KIEM_TRA_BAO_HIEM(@MaBenhNhan)";
            SqlParameter[] parameters = {
        new SqlParameter("@MaBenhNhan", SqlDbType.Char) { Value = maBenhNhan }
    };

            object result = db.ExecuteScalar(sql, parameters);
            return result != null && Convert.ToBoolean(result);
        }



        public int TongBenhNhanDangDieuTri()
        {
            DBConnect db = new DBConnect();

            string sql = "SELECT dbo.FUNC_TONG_BENH_NHAN_DANG_NAM_VIEN()";
            object result = db.ExecuteScalar(sql);
            return result != null ? Convert.ToInt32(result) : 0;
        }

    }
}
