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
    public class THUOC_DAL
    {
        string connStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=QLBV;Integrated Security=True";
        string sql = "select * from THUOC";
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tbl;
        DataColumn[] key = new DataColumn[1];
        public THUOC_DAL()
        {
            conn = new SqlConnection(connStr);
            adap = new SqlDataAdapter(sql, conn);
            tbl = new DataTable();
            adap.Fill(tbl);
            key[0] = tbl.Columns[0];
            tbl.PrimaryKey = key;
        }
        public List<THUOC_DTO>get_all()
        {
            List<THUOC_DTO>ds= new List<THUOC_DTO>();
            foreach (DataRow dr in tbl.Rows)
            {
                THUOC_DTO tmp = new THUOC_DTO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), float.Parse(dr[3].ToString()));
                ds.Add(tmp);
            }
            return ds;
        }
        public bool Them_Thuoc(THUOC_DTO tmp)
        {
            try
            {
                DataRow dr = tbl.NewRow();
                dr[0] = tmp.MaThuoc;
                dr[1] = tmp.TenThuoc;
                dr[2] = tmp.ThanhPhan;
                dr[3] = tmp.Gia.ToString();
                tbl.Rows.Add(dr);
                SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adap);
                adap.Update(tbl);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua_Thuoc(THUOC_DTO tmp)
        {
            foreach (DataRow dr in tbl.Rows)
            {
                if(dr[0].ToString().Trim()==tmp.MaThuoc.Trim())
                {
                    dr[1] = tmp.TenThuoc;
                    dr[2] = tmp.ThanhPhan;
                    dr[3] = tmp.Gia.ToString();
                    SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adap);
                    adap.Update(tbl);
                    return true;
                }    
            }    
            return false;
        }
        public bool Xoa_Thuoc(THUOC_DTO tmp)
        {
            try
            {
                foreach (DataRow dr in tbl.Rows)
                {
                    if (dr[0].ToString().Trim() == tmp.MaThuoc.Trim())
                    {
                        dr.Delete();
                        SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adap);
                        adap.Update(tbl);
                        return true;
                    }
                }
                return false;    
            }
            catch { return false; }
            
        }
    }
}
