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
    public partial class frmNhapThuoc : Form
    {
        public frmNhapThuoc()
        {
            InitializeComponent();
        }
        NHACCTHUOC_BLL nccBLL = new NHACCTHUOC_BLL();
        PHIEU_NHAP_THUOC_BLL pnt = new PHIEU_NHAP_THUOC_BLL();
        THUOC_BLL tBLL= new THUOC_BLL();
        PHIEU_NHAP_THUOC_DTO pnMain;
        public void load_NCC()
        {
            cbo_NCC.DataSource = nccBLL.get_all();
            cbo_NCC.DisplayMember = "TenNCC";
            cbo_NCC.ValueMember = "MaNCC";
        }
        public void load_THUOC()
        {
            dataGridView_DS_Thuoc.DataSource = null;
            dataGridView_DS_Thuoc.DataSource = tBLL.get_all();
        }
        private void frmNhapThuoc_Load(object sender, EventArgs e)
        {
            load_NCC();
            load_THUOC();
        }

        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            string ma = "PN" + DateTime.Today.ToString("yyMMdd")+string.Format("{0:00}",pnt.Dem_SL_PN()+1);
            txtMaPN.Text = ma;
            txtNgayNhap.Text = DateTime.Today.ToString("yyyy-MM-dd");
            pnMain = new PHIEU_NHAP_THUOC_DTO();
            pnMain.MaPN = txtMaPN.Text;
            pnMain.MaNCC = cbo_NCC.SelectedValue.ToString();
            pnMain.NgayNhap = DateTime.Today.ToString("yyyy-MM-dd");
            pnMain.ChITIET_PN = new List<CHITIET_PN_THUOC_DTO>();
 
        }

       

        private void dataGridView_DS_Thuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dataGridView_DS_Thuoc.SelectedRows[0].Cells[0].Value.ToString();
            THUOC_DTO tmp = tBLL.get_all().Find(d => d.MaThuoc == ma);
            if (tmp != null)
            {
                txtMaTHuoc.Text = tmp.MaThuoc;
                txtTenThuoc.Text = tmp.TenThuoc;
                txtSL.Text = "0";
                txtGia.Text = tmp.Gia.ToString();
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            
            CHITIET_PN_THUOC_DTO tmp = pnMain.ChITIET_PN.Find(d => d.MaThuoc == txtMaTHuoc.Text);
      
            if (tmp != null)
            {
 
                tmp.SL += int.Parse(txtSL.Text);
                pnMain.ThanhTien += int.Parse(txtSL.Text) * float.Parse(txtGia.Text);
            }
            else
            {
              
                CHITIET_PN_THUOC_DTO tmp1= new CHITIET_PN_THUOC_DTO(txtMaPN.Text,txtMaTHuoc.Text,int.Parse(txtSL.Text),float.Parse(txtGia.Text));
                pnMain.ChITIET_PN.Add(tmp1);
                pnMain.ThanhTien += tmp1.ThanhTien();
            }
       
            dataGridView_Chi_Tiet_PN.DataSource = null;
            dataGridView_Chi_Tiet_PN.DataSource = pnMain.ChITIET_PN;
            txtThanhTien.Text = pnMain.ThanhTien.ToString();
        }

        private void dataGridView_Chi_Tiet_PN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dataGridView_Chi_Tiet_PN.SelectedRows[0].Cells[1].Value.ToString();
            THUOC_DTO tmp = tBLL.get_all().Find(d => d.MaThuoc == ma);
            if (tmp != null)
            {
                txtMaTHuoc.Text = tmp.MaThuoc;
                txtTenThuoc.Text = tmp.TenThuoc;
                txtSL.Text = dataGridView_Chi_Tiet_PN.SelectedRows[0].Cells[2].Value.ToString();
                txtGia.Text = tmp.Gia.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int n = dataGridView_Chi_Tiet_PN.Rows.Count;
            if (dataGridView_Chi_Tiet_PN.SelectedRows != null)
            {
                for (int i = 0; i < n; i++) 
                {
                    if (pnMain.ChITIET_PN[i].MaThuoc == txtMaTHuoc.Text)
                    {
                        pnMain.ChITIET_PN.RemoveAt(i);
                        break;
                    } 
                        
                }    
            }
            else { MessageBox.Show("Chọn  Sản Phẩm Cần Loại Bỏ"); }
            dataGridView_Chi_Tiet_PN.DataSource = null;
            dataGridView_Chi_Tiet_PN.DataSource = pnMain.ChITIET_PN;
            pnMain.ThanhTien-=int.Parse(txtSL.Text)*float.Parse(txtGia.Text);
            txtThanhTien.Text = pnMain.ThanhTien.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CHITIET_PN_THUOC_DTO tmp = pnMain.ChITIET_PN.Find(d => d.MaThuoc == txtMaTHuoc.Text);

            if (tmp != null)
            {


                pnMain.ThanhTien += int.Parse(txtSL.Text) * float.Parse(txtGia.Text);

                pnMain.ThanhTien -= tmp.ThanhTien();
                tmp.SL = int.Parse(txtSL.Text);
            }
            dataGridView_Chi_Tiet_PN.DataSource = null;
            dataGridView_Chi_Tiet_PN.DataSource = pnMain.ChITIET_PN;
            txtThanhTien.Text = pnMain.ThanhTien.ToString();
        }

        private void btnLuuPN_Click(object sender, EventArgs e)
        {
            LUUKHO_BLL lkBLL= new LUUKHO_BLL();
            List<LUUKHO_DTO> ds = lkBLL.get_all();
            List<THUOC_DTO> dsThuoc= tBLL.get_all();
            if(pnt.insert_PN(pnMain))
            {
                CHITIET_PN_THUOC_BLL ctpnBLL = new CHITIET_PN_THUOC_BLL();
                foreach(CHITIET_PN_THUOC_DTO tmp in pnMain.ChITIET_PN)
                {
                    ctpnBLL.insert_ChiTiet_PN(tmp);
                    LUUKHO_DTO lk_TMP = ds.Find(d => d.MaThuoc == tmp.MaThuoc);
                    if(lk_TMP==null)
                    {
                        lk_TMP= new LUUKHO_DTO();
                        THUOC_DTO thuoc = dsThuoc.Find(d => d.MaThuoc == tmp.MaThuoc);
                        lk_TMP.MaThuoc= tmp.MaThuoc;
                        lk_TMP.TenThuoc = thuoc.TenThuoc;
                        lk_TMP.SLTon=tmp.SL;
                        lk_TMP.DonVi = "Viên";
                        lk_TMP.NgayNhap = DateTime.Today.ToString("yyyy-MM-dd");
                        lk_TMP.HanSuDung =DateTime.Today.AddYears(3).ToString("yyyy-MM-dd");
                        if(lkBLL.insert_luuKHo(lk_TMP)==false)
                        {
                            MessageBox.Show("Loi");
                        }    
                    }
                    else
                    {
                        if(lkBLL.them_SL_LuuKho(tmp)==false)
                        {
                            MessageBox.Show("Loi");
                        }
                    }
                    
                }    
                MessageBox.Show("Lưu Thành công Phiếu Nhập");
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
        }
    }
}
