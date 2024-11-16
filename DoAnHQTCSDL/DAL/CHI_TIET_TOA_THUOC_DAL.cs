using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using DTO;

namespace DAL
{
    public class CHI_TIET_TOA_THUOC_DAL
    {
        string connStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=QLBV;Integrated Security=True";
        string sql = "select * from CHITIETTOA";
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tbl;
        DataColumn[] key = new DataColumn[2];
        public CHI_TIET_TOA_THUOC_DAL()
        {
            conn = new SqlConnection(connStr);
            adap = new SqlDataAdapter(sql, conn);
            tbl = new DataTable();
            adap.Fill(tbl);
            key[0] = tbl.Columns[0];
            key[1] = tbl.Columns[1];
            tbl.PrimaryKey = key;
        }
        public List<CHI_TIET_TOA_THUOC_DTO>get_all()
        {
            List<CHI_TIET_TOA_THUOC_DTO>ds= new List<CHI_TIET_TOA_THUOC_DTO> ();
            foreach(DataRow dr in tbl.Rows)
            {
                CHI_TIET_TOA_THUOC_DTO tmp = new CHI_TIET_TOA_THUOC_DTO();
                tmp.MaToa = dr[0].ToString().Trim();
                tmp.MaThuoc = dr[1].ToString().Trim();
                tmp.SL = int.Parse(dr[2].ToString());
                tmp.CachDung = dr[3].ToString().Trim();
                ds.Add(tmp);
            }
            return ds ;
        }
    }
}
