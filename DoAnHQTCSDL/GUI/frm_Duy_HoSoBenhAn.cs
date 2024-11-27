using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility; 


namespace GUI
{
    public partial class frm_Duy_HoSoBenhAn : Form
    {
        private HO_SO_BENH_AN_BLL hoSoBenhAnBLL;

        private DBconnection dbConnection;
        public frm_Duy_HoSoBenhAn()
        {
            InitializeComponent();
            hoSoBenhAnBLL = new HO_SO_BENH_AN_BLL();
        }

        private void frm_Duy_HoSoBenhAn_Load(object sender, EventArgs e)
        {
            LoadDataHOSOBENHAN();
            LoadTongHoSo();


        }

        private void LoadDataHOSOBENHAN()
        {
            try
            {
                dgvTTHS.DataSource = hoSoBenhAnBLL.GetHoSoBenhAn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu hồ sơ bệnh án: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetNextMaHoSo()
        {
            string query = "SELECT TOP 1 MaHoSo FROM HOSOBENHAN ORDER BY MaHoSo DESC";
            if (dbConnection == null)
            {
                dbConnection = new DBconnection(); // Khởi tạo đối tượng dbConnection
            }
            var result = dbConnection.ExecuteScalar(query);
            if (result != null)
            {
                string maHoSoCuoi = result.ToString();
                int maHoSoSo = int.Parse(maHoSoCuoi.Substring(2));
                maHoSoSo++;
                return "HS" + maHoSoSo.ToString("D3");
            }
            else
            {
                return "HS001";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo mã hồ sơ tự động
                string maHoSo = GetNextMaHoSo();
                string maBenhNhan = txtMaBenhNhan.Text;
                string maBacSi = txtMaBacSi.Text;
                string noiDungHoSo = rtbNoiDung.Text;

                if (string.IsNullOrWhiteSpace(maBenhNhan) || string.IsNullOrWhiteSpace(maBacSi) || string.IsNullOrWhiteSpace(noiDungHoSo))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                HO_SO_BENH_AN_DTO hoSoBenhAn = new HO_SO_BENH_AN_DTO
                {
                    MaHoSo = maHoSo,
                    MaBenhNhan = maBenhNhan,
                    NgayLapHoSo = DateTime.Now,
                    MaBacSi = maBacSi,
                    NoiDungHoSo = noiDungHoSo
                };

                hoSoBenhAnBLL.AddHoSoBenhAn(hoSoBenhAn);
                MessageBox.Show("Thêm hồ sơ bệnh án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataHOSOBENHAN();
                LoadTongHoSo();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hồ sơ bệnh án: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTTHS_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTTHS.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTTHS.SelectedRows[0];

                // Cập nhật các trường thông tin
                txtMaHoSo.Text = selectedRow.Cells["MaHoSo"].Value.ToString();
                txtMaBenhNhan.Text = selectedRow.Cells["MaBenhNhan"].Value.ToString();
                txtMaBacSi.Text = selectedRow.Cells["MaBacSi"].Value.ToString();
                rtbNoiDung.Text = selectedRow.Cells["NoiDungHoSo"].Value.ToString();

                // Cập nhật ngày nhập
                dtpNgayLapHS.Value = Convert.ToDateTime(selectedRow.Cells["NgayLapHoSo"].Value);

                // Không cho phép sửa mã hồ sơ
                txtMaHoSo.Enabled = false; // Disable không cho sửa mã hồ sơ
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHoSo.Text) || string.IsNullOrEmpty(txtMaBenhNhan.Text) ||
        string.IsNullOrEmpty(txtMaBacSi.Text) || string.IsNullOrEmpty(rtbNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hồ sơ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin ngày nhập từ DateTimePicker
            DateTime ngayLapHoSo = dtpNgayLapHS.Value;

            // Xác nhận sửa hồ sơ
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa hồ sơ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string maHoSo = txtMaHoSo.Text;
                    string maBenhNhan = txtMaBenhNhan.Text;
                    string maBacSi = txtMaBacSi.Text;
                    string noiDungHoSo = rtbNoiDung.Text;

                    if (string.IsNullOrEmpty(maHoSo) || string.IsNullOrEmpty(maBenhNhan) || string.IsNullOrEmpty(maBacSi) || string.IsNullOrEmpty(noiDungHoSo))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin hồ sơ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    HO_SO_BENH_AN_DTO hoSoBenhAn = new HO_SO_BENH_AN_DTO
                    {
                        MaHoSo = maHoSo,
                        MaBenhNhan = maBenhNhan,
                        MaBacSi = maBacSi,
                        NoiDungHoSo = noiDungHoSo
                    };

                    hoSoBenhAnBLL.UpdateHoSoBenhAn(hoSoBenhAn);
                    MessageBox.Show("Sửa hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataHOSOBENHAN();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa hồ sơ bệnh án: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView chưa
            if (dgvTTHS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hồ sơ bệnh án cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy MaHoSo từ dòng đã chọn trong DataGridView
            string maHoSo = dgvTTHS.SelectedRows[0].Cells["MaHoSo"].Value.ToString();

            // Hỏi người dùng có chắc chắn muốn xóa không
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hồ sơ bệnh án này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Tạo đối tượng BLL để gọi phương thức xóa
                    HO_SO_BENH_AN_BLL hoSoBenhAnBLL = new HO_SO_BENH_AN_BLL();

                    // Gọi phương thức xóa hồ sơ bệnh án từ BLL
                    hoSoBenhAnBLL.DeleteHoSoBenhAn(maHoSo);

                    // Cập nhật lại DataGridView
                    LoadDataHOSOBENHAN();
                    LoadTongHoSo();


                    // Thông báo xóa thành công
                    MessageBox.Show("Xóa hồ sơ bệnh án thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtMaHoSo.Text = "";
            txtMaBenhNhan.Text = "";
            txtMaBacSi.Text = "";
            rtbNoiDung.Text = "";
            dtpNgayLapHS.Value = DateTime.Now;
            LoadTongHoSo();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form
            }
        }

        private List<HO_SO_BENH_AN_DTO> danhSachThem = new List<HO_SO_BENH_AN_DTO>();
        private List<HO_SO_BENH_AN_DTO> danhSachSua = new List<HO_SO_BENH_AN_DTO>();
        private List<string> danhSachXoa = new List<string>();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (danhSachThem.Count == 0 && danhSachSua.Count == 0 && danhSachXoa.Count == 0)
            {
                MessageBox.Show("Không có thay đổi nào để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn lưu tất cả các thay đổi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            try
            {
                // Thêm hồ sơ
                foreach (var hoSo in danhSachThem)
                    hoSoBenhAnBLL.AddHoSoBenhAn(hoSo);

                // Sửa hồ sơ
                foreach (var hoSo in danhSachSua)
                    hoSoBenhAnBLL.UpdateHoSoBenhAn(hoSo);

                // Xóa hồ sơ
                foreach (var maHoSo in danhSachXoa)
                    hoSoBenhAnBLL.DeleteHoSoBenhAn(maHoSo);

                MessageBox.Show("Lưu thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa danh sách thay đổi
                danhSachThem.Clear();
                danhSachSua.Clear();
                danhSachXoa.Clear();

                // Tải lại dữ liệu
                LoadDataHOSOBENHAN();
                LoadTongHoSo();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu thay đổi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTongHoSo()
        {
            try
            {
                // Gọi phương thức GetTotalHoSoBenhAn từ lớp BLL
                int tong = hoSoBenhAnBLL.GetTotalHoSoBenhAn();
                lbTong.Text = tong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy tổng số hồ sơ bệnh án: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
