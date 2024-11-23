using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NHACCTHUOC_DAL
    {
        dbContext dbContext = new dbContext();
        string sql = "select * from NHACCTHUOC";
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tbl;
        DataColumn[] key = new DataColumn[1];
        public NHACCTHUOC_DAL()
        {
            conn = new SqlConnection(dbContext.strcon);
            adap = new SqlDataAdapter(sql, conn);
            tbl = new DataTable();
            adap.Fill(tbl);
            key[0]= tbl.Columns[0];
            tbl.PrimaryKey = key;
        }
        public List<NHACCTHUOC_DTO> get_all()
        {
            List<NHACCTHUOC_DTO>ds= new List<NHACCTHUOC_DTO>();
            foreach (DataRow dr in tbl.Rows)
            {
                NHACCTHUOC_DTO tmp = new NHACCTHUOC_DTO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                ds.Add(tmp);
            }
            return ds;
        }
    }
}
