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
    public class CHITIET_PN_THUOC_DAL
    {
        string connStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=QLBV;Integrated Security=True";
        string sql = "select * from CHITIET_PN_THUOC";
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tbl;
        DataColumn[] key = new DataColumn[2];
        public CHITIET_PN_THUOC_DAL()
        {
            conn = new SqlConnection(connStr);
            adap = new SqlDataAdapter(sql, conn);
            tbl = new DataTable();
            adap.Fill(tbl);
            key[0] = tbl.Columns[0];
            key[1] = tbl.Columns[1];
            tbl.PrimaryKey = key;
        }
        public bool insert_ChiTiet_PN(CHITIET_PN_THUOC_DTO tmp)
        {
            try
            {
                DataRow dr = tbl.NewRow();
                dr[0] = tmp.MaPN;
                dr[1] = tmp.MaThuoc.Trim();
                dr[2] = tmp.SL;
                dr[3] = tmp.Gia;
                tbl.Rows.Add(dr);
                SqlCommandBuilder sqlcm = new SqlCommandBuilder(adap);
                adap.Update(tbl);
                return true;
            }
            catch
            {
                return false;
            }
        }
      

    }
}
