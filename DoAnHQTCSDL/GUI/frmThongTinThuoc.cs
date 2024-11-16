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
    public partial class frmThongTinThuoc : Form
    {
        public frmThongTinThuoc()
        {
            InitializeComponent();
        }
        THUOC_BLL thuocBLL = new THUOC_BLL();
        List<THUOC_DTO> dsTHuoc;
        private void frmThongTinThuoc_Load(object sender, EventArgs e)
        {
            dsTHuoc = thuocBLL.get_all();
            dataGridView_DS_Thuoc.DataSource = null;
            dataGridView_DS_Thuoc.DataSource = dsTHuoc;
        }

        private void dataGridView_DS_Thuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dataGridView_DS_Thuoc.SelectedRows[0].Cells[0].Value.ToString();
            THUOC_DTO thuoc = dsTHuoc.Find(d=>d.MaThuoc.Trim()==ma.Trim());
            if (thuoc != null)
            {
                txtMaThuoc.Text = thuoc.MaThuoc;
                txtTenThuoc.Text= thuoc.TenThuoc;
                txtThanhPhan.Text= thuoc.ThanhPhan;
                txtGia.Text=thuoc.Gia.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            THUOC_DTO tmp = new THUOC_DTO();
            tmp.MaThuoc = txtMaThuoc.Text;
            tmp.TenThuoc = txtTenThuoc.Text;
            tmp.ThanhPhan   = txtThanhPhan.Text;
            tmp.Gia=float.Parse(txtGia.Text);
            if (thuocBLL.Them_Thuoc(tmp))
            {
                dataGridView_DS_Thuoc.DataSource = null;
                dataGridView_DS_Thuoc.DataSource = thuocBLL.get_all();
                MessageBox.Show("Thêm THành Công");
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            THUOC_DTO thuoc = new THUOC_DTO();
            thuoc.MaThuoc = txtMaThuoc.Text;
            thuoc.TenThuoc = txtTenThuoc.Text;
            thuoc.ThanhPhan = txtThanhPhan.Text;
            thuoc.Gia = float.Parse(txtGia.Text);
            if (thuocBLL.Sua_Thuoc(thuoc))
            {
                dataGridView_DS_Thuoc.DataSource = null;
                dataGridView_DS_Thuoc.DataSource = thuocBLL.get_all();
                MessageBox.Show("Sửa Thành Công");
            }
            else
            {
                MessageBox.Show("Sửa thất Bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            THUOC_DTO thuoc = new THUOC_DTO();
            thuoc.MaThuoc = txtMaThuoc.Text;
            thuoc.TenThuoc = txtTenThuoc.Text;
            thuoc.ThanhPhan = txtThanhPhan.Text;
            thuoc.Gia = float.Parse(txtGia.Text);
            if (thuocBLL.Xoa_Thuoc(thuoc))
            {
                dataGridView_DS_Thuoc.DataSource = null;
                dataGridView_DS_Thuoc.DataSource = thuocBLL.get_all();
                MessageBox.Show("Xoa Thành Công");
            }
            else
            {
                MessageBox.Show("Xoa thất Bại, kiểm tra chọn thuốc cần xóa và các hóa đơn, phiếu nhập liên qua");
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaThuoc.Clear();
            txtGia.Clear();
            txtTenThuoc.Clear();
            txtThanhPhan.Clear();
            frmThongTinThuoc_Load(sender, e);
        }
    }
}
