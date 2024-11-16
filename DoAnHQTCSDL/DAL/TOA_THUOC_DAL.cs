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
    public class TOA_THUOC_DAL
    {
        string connStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=QLBV;Integrated Security=True";
        string sql = "select * from TOATHUOC";
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tbl;
        DataColumn[] key = new DataColumn[1];
        public TOA_THUOC_DAL()
        {
            conn = new SqlConnection(connStr);
            adap = new SqlDataAdapter(sql, conn);
            tbl = new DataTable();
            adap.Fill(tbl);
            key[0] = tbl.Columns[0];
            tbl.PrimaryKey = key;
        }
        public List<TOA_THUOC_DTO>get_all()
        {
            List<TOA_THUOC_DTO> ds = new List<TOA_THUOC_DTO> ();    
            foreach (DataRow dr in tbl.Rows)
            {
                TOA_THUOC_DTO tmp = new TOA_THUOC_DTO();
                tmp.MaToa = dr[0].ToString().Trim();
                tmp.NgayKetToa = dr[1].ToString();
                tmp.SoNgayDung = int.Parse(dr[2].ToString());
                tmp.NgayKetThuc = dr[3].ToString();
                tmp.SoLoaiThuoc = int.Parse(dr[4].ToString());
                tmp.MaBacSi = dr[5].ToString();
                ds.Add(tmp);
            }
            return ds;
        }
    }
}
