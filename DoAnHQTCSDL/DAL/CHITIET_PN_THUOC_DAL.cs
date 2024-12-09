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
        dbContext dbContext = new dbContext();
        string sql = "select * from CHITIET_PN_THUOC";
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tbl;
        DataColumn[] key = new DataColumn[2];
        public CHITIET_PN_THUOC_DAL()
        {
            conn = new SqlConnection(dbContext.strcon);
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
        public List<CHITIET_PN_THUOC_DTO>get_all()
        {
            List<CHITIET_PN_THUOC_DTO>ds = new List<CHITIET_PN_THUOC_DTO> ();
            foreach(DataRow dr in tbl.Rows)
            {
                CHITIET_PN_THUOC_DTO tmp = new CHITIET_PN_THUOC_DTO(dr[0].ToString().Trim(), dr[1].ToString().Trim(), int.Parse(dr[2].ToString().Trim()), float.Parse(dr[3].ToString().Trim()));
                ds.Add(tmp);
            }    
            return ds;
        }
      

    }
}
