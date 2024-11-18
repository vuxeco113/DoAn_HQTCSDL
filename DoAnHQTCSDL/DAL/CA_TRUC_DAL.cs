using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CA_TRUC_DAL
    {
        dbContext dbContext = new dbContext();
        string sql = "select * from CATRUC";
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tbl;
        DataColumn[] key = new DataColumn[1];
        public CA_TRUC_DAL()
        {
            conn = new SqlConnection(dbContext.strcon);
            adap = new SqlDataAdapter(sql, conn);
            tbl = new DataTable();
            adap.Fill(tbl);
            key[0] = tbl.Columns[0];
            tbl.PrimaryKey = key;
        }
        public List<CA_TRUC_DTO> get_all()
        {
            List<CA_TRUC_DTO> ds = new List<CA_TRUC_DTO>();
            foreach (DataRow dr in tbl.Rows)
            {
                CA_TRUC_DTO tmp = new CA_TRUC_DTO(dr[0].ToString(), dr[1].ToString());
                ds.Add(tmp);
            }
            return ds;
        }
        
    }
}
