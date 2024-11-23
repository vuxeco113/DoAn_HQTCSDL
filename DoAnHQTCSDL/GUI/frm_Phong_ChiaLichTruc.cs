using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frm_Phong_LichTruc : Form
    {
        CA_TRUC_BLL catruc = new CA_TRUC_BLL();
        BAC_SI_BLL bacsi = new BAC_SI_BLL();
        LICH_TRUC_BLL lichTrucBLL = new LICH_TRUC_BLL();
        public frm_Phong_LichTruc()
        {
            InitializeComponent();
            LoadCaTruc();
            LoadBacSi();
            txtMaLichTruc.Text = SinhMaLichTruc();
            Loaddgv();
        }
        public void LoadCaTruc()
        {
            cboCaTruc.Items.Clear();
            cboCaTruc.DataSource = catruc.get_all();
            cboCaTruc.DisplayMember = "ThoiGianCa";
            cboCaTruc.ValueMember = "MaCaTruc";
        }
        public void LoadBacSi()
        {
            cboBacsi.Items.Clear();
            cboBacsi.DataSource = bacsi.GetAllBacSi();
            cboBacsi.DisplayMember = "HoTen";
            cboBacsi.ValueMember = "MaBacSi";
        }
        private string SinhMaLichTruc()
        {
            string prefix = "ML"; // Phần đầu cố định
            string date = DateTime.Now.ToString("ddMMyy"); // Ngày hiện tại (DDMMYY)

            int countToday = lichTrucBLL.DemSoLichTrongNgay(DateTime.Now); // Số lần mã được tạo trong ngày

            // Tạo mã mới
            string maLichTruc = $"{prefix}{date}{(countToday + 1).ToString("D2")}";
            return maLichTruc;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public void Loaddgv()
        {
            dgvView.DataSource = lichTrucBLL.LayDanhSachLichTruc();
            dgvView.Refresh();
        }

        private void btnThemLichTruc_Click(object sender, EventArgs e)
        {
            try
            {
                LICH_TRUC_DTO lichTruc = new LICH_TRUC_DTO
                {
                    MaLichTruc = txtMaLichTruc.Text.Trim(),
                    MaBacSi = cboBacsi.SelectedValue.ToString(),
                    NgayTruc = dtpNgayTruc.Value,
                    MaCaTruc = cboCaTruc.Text.Trim()
                };

                if (lichTrucBLL.ThemLichTruc(lichTruc))
                {
                    MessageBox.Show("Lưu lịch trực thành công!", "Thông báo");
                    Loaddgv();
                }
                else
                {
                    MessageBox.Show("Lưu lịch trực thất bại!", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }

        private void btnXoaLichTruc_Click(object sender, EventArgs e)
        {
            try
            {
                string maLichTruc = txtMaLichTruc.Text.Trim();

                if (string.IsNullOrEmpty(maLichTruc))
                {
                    MessageBox.Show("Vui lòng nhập mã lịch trực cần xóa!", "Cảnh báo");
                    return;
                }

                if (lichTrucBLL.XoaLichTruc(maLichTruc))
                {
                    MessageBox.Show("Xóa lịch trực thành công!", "Thông báo");
                    Loaddgv();
                }
                else
                {
                    MessageBox.Show("Xóa lịch trực thất bại!", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }

        private void btnDoiLichTruc_Click(object sender, EventArgs e)
        {
            try
            {
                LICH_TRUC_DTO lichTruc = new LICH_TRUC_DTO
                {
                    MaLichTruc = txtMaLichTruc.Text.Trim(),
                    MaBacSi = cboBacsi.SelectedValue.ToString(),
                    NgayTruc = dtpNgayTruc.Value,
                    MaCaTruc = cboCaTruc.Text.Trim()
                };

                if (lichTrucBLL.SuaLichTruc(lichTruc))
                {
                    MessageBox.Show("Đổi lịch trực thành công!", "Thông báo");
                    Loaddgv();
                }
                else
                {
                    MessageBox.Show("Đổi lịch trực thất bại!", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvView.Rows[e.RowIndex];
                txtMaLichTruc.Text = row.Cells["MaLichTruc"].Value.ToString();
                cboBacsi.SelectedValue = row.Cells["MaBacSi"].Value.ToString();
                dtpNgayTruc.Value = Convert.ToDateTime(row.Cells["NgayTruc"].Value);
                cboCaTruc.Text = row.Cells["MaCaTruc"].Value.ToString();
            }
        }
    }
}
