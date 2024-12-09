using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        PHIEU_NHAP_THUOC_BLL pntBLL= new PHIEU_NHAP_THUOC_BLL();
        CHITIET_PN_THUOC_BLL ctpnBLL = new CHITIET_PN_THUOC_BLL();
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView_PNT.DataSource = null;
            dataGridView_PNT.DataSource = pntBLL.get_all();

        }

        private void dataGridView_PNT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dataGridView_PNT.SelectedRows[0].Cells[0].Value.ToString();
            List<PHIEU_NHAP_THUOC_DTO> ds = pntBLL.get_all();
            PHIEU_NHAP_THUOC_DTO tmp = ds.Find(s => s.MaPN == ma);
            if (tmp != null)
            {
                txtMaPN.Text = tmp.MaPN;
                txtNCC.Text = tmp.MaNCC;
                txtThanhTien.Text=tmp.ThanhTien.ToString();
                txtNgayNhap.Text = tmp.NgayNhap;
            }
        }

        private void btnxemChiTiet_Click(object sender, EventArgs e)
        {
            dataGridView_PNT.DataSource = null;
            List<CHITIET_PN_THUOC_DTO> ds= ctpnBLL.get_all();
            List<CHITIET_PN_THUOC_DTO> ds1 = new List<CHITIET_PN_THUOC_DTO>();
            foreach(CHITIET_PN_THUOC_DTO tmp in ds)
            {
                if(tmp.MaPN.Trim()==txtMaPN.Text.Trim())
                {
                    ds1.Add(tmp);
                }    
            }
            dataGridView_PNT.DataSource = ds1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPhieuNhap_Load(sender, e);
        }
    }
}
