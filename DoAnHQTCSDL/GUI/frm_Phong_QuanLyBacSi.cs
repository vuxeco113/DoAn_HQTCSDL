using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Phong_QuanLyBacSi : Form
    {
        private BAC_SI_BLL bll = new BAC_SI_BLL();

        public frm_Phong_QuanLyBacSi()
        {
            InitializeComponent();
            Loaddgv();
            LoadKhoa();
        }

        private void Loaddgv()
        {
            dgvBacSi.DataSource = bll.GetAllBacSi();
        }
        private void LoadKhoa()
        {
            List<KHOA_DTO> khoaList = bll.LoadKhoa();
            cboKhoa.DataSource = khoaList;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            BAC_SI_DTO bacSi = new BAC_SI_DTO
            {
                MaBacSi = txt_MaBacSi.Text,
                HoTen = txt_TenBacSi.Text,
                MaKhoa = cboKhoa.SelectedValue.ToString(),
                SoDienThoai = txt_SDT.Text,
                SoCaTruc = int.Parse(txt_Socatruc.Text),
                MatKhau = txt_pass.Text,
                ChucVu = txt_ChucVu.Text
            };

            if (bll.ThemBacSi(bacSi))
            {
                MessageBox.Show("Thêm bác sĩ thành công!");
                Loaddgv();
            }
            else
            {
                MessageBox.Show("Thêm bác sĩ thất bại.");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            BAC_SI_DTO bacSi = new BAC_SI_DTO
            {
                MaBacSi = txt_MaBacSi.Text,
                HoTen = txt_TenBacSi.Text,
                MaKhoa = cboKhoa.SelectedValue.ToString(),
                SoDienThoai = txt_SDT.Text,
                SoCaTruc = int.Parse(txt_Socatruc.Text),
                MatKhau = txt_pass.Text,
                ChucVu = txt_ChucVu.Text
            };

            if (bll.SuaBacSi(bacSi))
            {
                MessageBox.Show("Sửa thông tin bác sĩ thành công!");
                Loaddgv();
            }
            else
            {
                MessageBox.Show("Sửa thông tin bác sĩ thất bại.");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (bll.XoaBacSi(txt_MaBacSi.Text))
            {
                MessageBox.Show("Xóa bác sĩ thành công!");
                Loaddgv();
            }
            else
            {
                MessageBox.Show("Xóa bác sĩ thất bại.");
            }
        }

        private void dgvBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBacSi.Rows[e.RowIndex];
                txt_MaBacSi.Text = row.Cells["MaBacSi"].Value.ToString();
                txt_TenBacSi.Text = row.Cells["HoTen"].Value.ToString();
                cboKhoa.SelectedValue = row.Cells["MaKhoa"].Value.ToString();
                txt_SDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txt_Socatruc.Text = row.Cells["SoCaTruc"].Value.ToString();
                txt_pass.Text = row.Cells["MatKhau"].Value.ToString();
                txt_ChucVu.Text = row.Cells["ChucVu"].Value.ToString();
            }
        }
    }
}
