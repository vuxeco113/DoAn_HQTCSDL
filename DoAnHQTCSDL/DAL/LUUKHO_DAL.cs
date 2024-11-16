using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LUUKHO_DAL
    {
        string connStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=QLBV;Integrated Security=True";
        string sql = "select * from LUUKHO";
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tbl;
        DataColumn[] key = new DataColumn[1];
        public LUUKHO_DAL()
        {
            conn = new SqlConnection(connStr);
            adap = new SqlDataAdapter(sql, conn);
            tbl = new DataTable();
            adap.Fill(tbl);
            key[0] = tbl.Columns[0];
            tbl.PrimaryKey = key;
        }
        public bool insert_LUUKHO(LUUKHO_DTO tmp)
        {
            try
            {
                DataRow dr = tbl.NewRow();
                dr[0] = tmp.MaThuoc;
                dr[1] = tmp.TenThuoc;
                dr[2] = tmp.SLTon;
                dr[3] = tmp.DonVi;
                dr[4] = DateTime.Today.ToString("yyyy-MM-dd");
                dr[5] = tmp.HanSuDung;
                tbl.Rows.Add(dr);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
                adap.Update(tbl);
                return true;
            }
            catch {  return false; }
        }
        public bool ThemSLTon_LuuKho(CHITIET_PN_THUOC_DTO tmp)
        {
            foreach(DataRow dr in tbl.Rows)
            {
                if (dr[0].ToString() == tmp.MaThuoc)
                {
                    int sl= int.Parse(dr[2].ToString())+tmp.SL;
                    dr[2] = sl.ToString();
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
                    adap.Update(tbl);
                    return true;
                    
                }

            }
            return false;
        }
        public List<LUUKHO_DTO> get_all()
        {
            List<LUUKHO_DTO> ds = new List<LUUKHO_DTO> ();
            foreach(DataRow dr in tbl.Rows)
            {
                LUUKHO_DTO tmp = new LUUKHO_DTO();
                tmp.MaThuoc = dr[0].ToString();
                tmp.TenThuoc = dr[1].ToString();
                tmp.SLTon= int.Parse(dr[2].ToString());
                tmp.DonVi = dr[3].ToString();
                tmp.NgayNhap= dr[4].ToString();
                tmp.HanSuDung= dr[5].ToString();
                ds.Add(tmp);
            }
            return ds;
        }
        public bool Lay1LoaiThuoc_TheoToa(CHI_TIET_TOA_THUOC_DTO tmp)
        {
            foreach (DataRow dr in tbl.Rows)
            {
                if (dr[0].ToString().Trim() == tmp.MaThuoc)
                {
                    int sl = int.Parse(dr[2].ToString())-tmp.SL;
                    dr[2]= sl.ToString();
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
                    adap.Update(tbl);
                    return true;

                }

            }
            return false;
        }
    }
}
