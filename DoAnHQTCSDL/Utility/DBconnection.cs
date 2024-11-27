using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Utility
{
    public class DBconnection
    {
        SqlConnection conn;
        string strconnect = "Data Source=LAPTOP-7V4UTMER\\SQLEXPRESS;Initial Catalog=QLBV;Integrated Security=True";
        public DBconnection()
        {
            conn = new SqlConnection(strconnect);
        }
        public void openconnect()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeconnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public int getNonQuery(string sql)
        {
            openconnect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            closeconnect();
            return kq;
        }
        public object getExcecutesalar(string sql)
        {
            openconnect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object kq = cmd.ExecuteScalar();
            closeconnect();
            return kq;
        }
        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            return dt;
        }
        public int insertDatatable(string sql, DataTable dt)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(da);
            int kq = da.Update(dt);
            return kq;
        }
        public int thutucthemBN(string maBenhNhan, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai, string maBHYT, string TrangThai, string tukhoa, string denkhoa)
        {
            try
            {
                openconnect();
                using (SqlCommand cmd = new SqlCommand("PROC_THEMBENHNHAN", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@MaBHYT", maBHYT);
                    cmd.Parameters.AddWithValue("@TrangThai", TrangThai);
                    cmd.Parameters.AddWithValue("@Tukhoa", tukhoa);
                    cmd.Parameters.AddWithValue("@Denkhoa", string.IsNullOrEmpty(denkhoa) ? (object)DBNull.Value : denkhoa);

                    // Thực thi thủ tục
                    int kq = cmd.ExecuteNonQuery();
                    return kq;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                closeconnect();
            }
        }
        public int thutucsuaBN(string maBenhNhan, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai, string maBHYT, string tukhoa, string denkhoa)
        {
            try
            {
                openconnect();
                using (SqlCommand cmd = new SqlCommand("PROC_SUABENHNHAN", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@MaBHYT", maBHYT);
                    cmd.Parameters.AddWithValue("@Tukhoa", tukhoa);
                    cmd.Parameters.AddWithValue("@Denkhoa", string.IsNullOrEmpty(denkhoa) ? (object)DBNull.Value : denkhoa);

                    // Thực thi thủ tục
                    int kq = cmd.ExecuteNonQuery();
                    return kq;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                closeconnect();
            }
        }

        public int thutucxoaBN(string maBenhNhan)
        {
            try
            {
                openconnect();
                using (SqlCommand cmd = new SqlCommand("PROC_XOABENHNHAN", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);

                    // Thực thi thủ tục
                    int kq = cmd.ExecuteNonQuery();
                    return kq;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                closeconnect();
            }
        }


        public DataTable GetDanhSachBenhNhanDieuTri(string maBacSi)
        {
            try
            {
                openconnect();
                string query = "SELECT * FROM FUNC_DANH_SACH_BENH_NHAN_DIEU_TRI(@MaBacSi)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@MaBacSi", maBacSi);
                    // Tạo DataAdapter để lưu kết quả trả về từ câu lệnh
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    // Tạo DataTable để chứa dữ liệu trả về
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {

                closeconnect();
            }
        }

        public DataTable GetDanhSachBenhNhan(string MaBenhNhan)
        {
            try
            {
                openconnect();
                string query = "SELECT * FROM FUNC_DANH_SACH_BENH_NHAN(@MaBenhNhan)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@MaBenhNhan", MaBenhNhan);
                    // Tạo DataAdapter để lưu kết quả trả về từ câu lệnh
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    // Tạo DataTable để chứa dữ liệu trả về
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {

                closeconnect();
            }
        }

        public DataTable Getlichsukhambenh(string maBN)
        {
            try
            {
                openconnect();
                string query = "SELECT * FROM FUNC_LICH_SU_KHAM_BENH(@MaBenhNhan)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@MaBenhNhan", maBN);
                    // Tạo DataAdapter để lưu kết quả trả về từ câu lệnh
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    // Tạo DataTable để chứa dữ liệu trả về
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {

                closeconnect();
            }
        }

        public DataTable GetthongtinBN(string maBN)
        {
            try
            {
                openconnect();
                string query = "SELECT * FROM FUNC_THONG_TIN_BENH_NHAN(@MaBenhNhan)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@MaBenhNhan", maBN);
                    // Tạo DataAdapter để lưu kết quả trả về từ câu lệnh
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    // Tạo DataTable để chứa dữ liệu trả về
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {

                closeconnect();
            }
        }


        public int TiepNhanBenhNhan(string maphieukham, string maBenhNhan, DateTime ngayKham, string chandoan, string mabacsi, string ketqua, float giakham, string matoa)
        {
            try
            {
                openconnect();
                using (SqlCommand cmd = new SqlCommand("PROC_TIEPNHANBENHNHAN", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuKham", maphieukham);
                    cmd.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);
                    cmd.Parameters.AddWithValue("@NgayKham", ngayKham);
                    cmd.Parameters.AddWithValue("@ChanDoan", chandoan);
                    cmd.Parameters.AddWithValue("@MaBacSi", mabacsi);
                    cmd.Parameters.AddWithValue("@KetQua", ketqua);
                    cmd.Parameters.AddWithValue("@GiaKham", giakham);
                    cmd.Parameters.AddWithValue("@MaToa", string.IsNullOrEmpty(matoa) ? (object)DBNull.Value : matoa);


                    int kq = cmd.ExecuteNonQuery();
                    return kq;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                closeconnect();
            }
        }

        public void PhanBoBacSiKham(string maPhieuKham, string maBacSi)
        {
            try
            {
                openconnect();
                string query = "PROC_PHANBOBACSIKHAM";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuKham", maPhieuKham);
                    cmd.Parameters.AddWithValue("@MaBacSi", maBacSi);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bác sĩ đã được phân bổ");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeconnect();
            }
        }
        public void KhamLamSang(string maPhieuKham, string chanDoan, string ketQua)
        {
            try
            {
                openconnect();
                string query = "PROC_KHAMLAMSANG";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuKham", maPhieuKham);
                    cmd.Parameters.AddWithValue("@ChanDoan", chanDoan);
                    cmd.Parameters.AddWithValue("@KetQua", ketQua);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Khám lâm sàng hoàn tất");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeconnect();
            }
        }

        public int thutucxoaPK(string MaPhieuKham)
        {
            try
            {
                openconnect();
                using (SqlCommand cmd = new SqlCommand("PROC_XOAPHIEUKHAM", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuKham", MaPhieuKham);

                    // Thực thi thủ tục
                    int kq = cmd.ExecuteNonQuery();
                    return kq;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                closeconnect();
            }
        }
        public DataTable GetDanhSachphieukham(string MaPhieuKham)
        {
            try
            {
                openconnect();
                string query = "SELECT * FROM FN_danhsachphieukham(@MaPhieuKham)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@MaPhieuKham", MaPhieuKham);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {

                closeconnect();
            }
        }

        public DataTable GetDanhSachphieukhamTheoNgay(DateTime NgayKham)
        {
            try
            {
                openconnect();
                string query = "SELECT * FROM FN_danhsachphieukhamtheongay(@NgayKham)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NgayKham", NgayKham);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {

                closeconnect();
            }
        }

        public string GetTinhTrangSucKhoe(string maPhieuKham)
        {
            try
            {
                openconnect();
                string query = "SELECT dbo.FUNC_TINH_TRANG_SUC_KHOE(@MaPhieuKham)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@MaPhieuKham", maPhieuKham);


                    object result = cmd.ExecuteScalar();

                    return result != null ? result.ToString() : "Chưa có kết quả khám";
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                closeconnect();
            }
        }

        public bool InsertChiDinhXetNghiem(string MaChiDinh, string maPhieuKham, string loaiChiDinh, DateTime ngayChiDinh)
        {
            try
            {
                openconnect();

                using (SqlCommand cmd = new SqlCommand("PROC_CDXETNGHIEM", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaChiDinh", MaChiDinh);
                    cmd.Parameters.AddWithValue("@MaPhieuKham", maPhieuKham);
                    cmd.Parameters.AddWithValue("@LoaiChiDinh", loaiChiDinh);
                    cmd.Parameters.AddWithValue("@NgayChiDinh", ngayChiDinh);


                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                closeconnect();
            }
        }

        public DataTable GetAllChiDinhXetNghiem()
        {
            try
            {
                openconnect();

                string query = "SELECT * FROM CHIDINHXETNGHIEM";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                closeconnect();
            }
        }
        public DataTable GetAllPhieuKham()
        {
            try
            {
                openconnect();

                string query = "SELECT * FROM PHIEUKHAM";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                closeconnect();
            }
        }

        public bool UpdateKetQuaXetNghiem(string maPhieuKham, string ketQuaXetNghiem)
        {
            try
            {
                openconnect();

                using (SqlCommand cmd = new SqlCommand("PROC_XULYKETQUAXETNGHIEM", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@MaPhieuKham", maPhieuKham);
                    cmd.Parameters.AddWithValue("@KetQuaXetNghiem", ketQuaXetNghiem);


                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                closeconnect();
            }
        }

        public bool CallPhacDoDieuTri(string maPhieuKham, string maToa, DateTime ngayKetToa, int soNgayDung, DateTime ngayKetThuc, int soLoaiThuoc, string maBacSi)
        {
            try
            {
                openconnect();

                using (SqlCommand cmd = new SqlCommand("PhacDoDieuTri", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuKham", maPhieuKham);
                    cmd.Parameters.AddWithValue("@MaToa", maToa);
                    cmd.Parameters.AddWithValue("@NgayKetToa", ngayKetToa);
                    cmd.Parameters.AddWithValue("@SoNgayDung", soNgayDung);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                    cmd.Parameters.AddWithValue("@SoLoaiThuoc", soLoaiThuoc);
                    cmd.Parameters.AddWithValue("@MaBacSi", maBacSi);

                    // Thực thi stored procedure
                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (SqlException ex)
            {

                // Kiểm tra thông báo lỗi từ trigger
                if (ex.Message.Contains("Bác sĩ kê toa không được trùng với bác sĩ khám"))
                {
                    MessageBox.Show("Bác sĩ kê toa không được trùng với bác sĩ khám.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false; // Thao tác thất bại
            }
            finally
            {
                closeconnect();
            }
        }
        public int GetTongSoNgayDungThuoc(string maBenhNhan)
        {
            try
            {
                openconnect();

                string query = "SELECT dbo.FUNC_TONG_SO_NGAY_DUNG_THUOC(@MaBenhNhan) AS TongSoNgayDung";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);


                    object result = cmd.ExecuteScalar();


                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                closeconnect();
            }
        }

        public int thutucxoaToa(string MaToa)
        {
            try
            {
                openconnect();
                using (SqlCommand cmd = new SqlCommand("PROC_XOATOA", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaToa", MaToa);


                    int kq = cmd.ExecuteNonQuery();
                    return kq;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                closeconnect();
            }
        }
        public DataTable GetToaThuocTheoBenhNhan(string maBenhNhan)
        {
            try
            {
                openconnect();

                string query = "SELECT * FROM dbo.FUNC_TOA_THUOC_THEO_BENH_NHAN(@MaBenhNhan)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                closeconnect();
            }
        }
        public DataTable GetToaThuocTheoToathuoc(string MATOA)
        {
            try
            {
                openconnect();

                string query = "SELECT * FROM dbo.FUNC_TOA_THUOC_THEO_TOA_THUOC(@MATOA)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@MATOA", MATOA);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                closeconnect();
            }
        }
        public DataTable GetDSThuoc(string maToa)
        {
            try
            {
                openconnect();

                string query = "SELECT * FROM FUNC_CHI_TIET_TOA_THUOC(@MaToa)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@MaToa", maToa);


                    DataTable dt = new DataTable();


                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    return dt;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                closeconnect();
            }
        }

        public int GetTongSoThuocTrongToa(string maToa)
        {
            try
            {
                openconnect();


                string query = "SELECT dbo.FUNC_TONG_SO_THUOC_TRONG_TOA(@MaToa) AS TongSoThuoc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@MaToa", maToa);


                    object result = cmd.ExecuteScalar();


                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                closeconnect();
            }
        }

        public DataTable GetChiTietToaThuoc(string maToa)
        {
            try
            {
                openconnect();


                string query = "SELECT * FROM dbo.FN_ChiTietToaThuoc(@MaToa)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@MaToa", maToa);


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                closeconnect();
            }
        }
        public bool ThanhToanThuTuc(string Mathanhtoan, string maPhieuKham, float soTien)
        {
            try
            {
                openconnect();

                using (SqlCommand cmd = new SqlCommand("PROC_THANHTOANTHUTUC", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Mathanhtoan", Mathanhtoan);
                    cmd.Parameters.AddWithValue("@MaPhieuKham", maPhieuKham);
                    cmd.Parameters.AddWithValue("@SoTien", soTien);

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                closeconnect();
            }
        }

        public int TinhTuoi(DateTime ngaySinh)
        {
            try
            {
                openconnect(); // Mở kết nối đến cơ sở dữ liệu

                using (SqlCommand cmd = new SqlCommand("SELECT dbo.TINH_TUOI(@NgaySinh)", conn))
                {
                    cmd.CommandType = CommandType.Text;

                    // Thêm tham số @NgaySinh
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);

                    // Thực thi và nhận kết quả
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result); // Trả về tuổi
                    }
                    else
                    {
                        throw new Exception("Không thể tính tuổi. Kết quả trả về null.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Trả về giá trị lỗi
            }
            finally
            {
                closeconnect(); // Đóng kết nối
            }
        }

        // Phương thức ExecuteScalar (dành cho các câu lệnh trả về một giá trị)
        public object ExecuteScalar(string query, List<SqlParameter> parameters = null)
        {
            try
            {
                // Mở kết nối
                openconnect();

                // Tạo câu lệnh SQL
                SqlCommand command = new SqlCommand(query, conn);

                // Thêm các tham số (nếu có)
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }

                // Thực thi câu lệnh SQL và trả về một giá trị đơn
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine("Lỗi khi thực thi câu lệnh: " + ex.Message);
                return null;
            }
            finally
            {
                // Đóng kết nối sau khi thực hiện xong
                closeconnect();
            }
        }

        // Phương thức ExecuteQuery (dành cho các câu lệnh không trả về giá trị)
        public void ExecuteQuery(string query, List<SqlParameter> parameters = null)
        {
            try
            {
                // Mở kết nối
                openconnect();

                // Tạo câu lệnh SQL
                SqlCommand command = new SqlCommand(query, conn);

                // Thêm các tham số (nếu có)
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }

                // Thực thi câu lệnh SQL
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine("Lỗi khi thực thi câu lệnh: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối sau khi thực hiện xong
                closeconnect();
            }
        }

        public DataTable GetDataTable(string sql, List<SqlParameter> parameters)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }





    }
}
