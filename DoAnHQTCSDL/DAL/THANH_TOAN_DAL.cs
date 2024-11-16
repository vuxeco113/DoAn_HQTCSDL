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
    public class THANH_TOAN_DAL
    {
        string connStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=QLBV;Integrated Security=True";
        string sql = "select * from THANHTOAN";
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tbl;
        DataColumn[] key = new DataColumn[1];
        public THANH_TOAN_DAL()
        {
            conn = new SqlConnection(connStr);
            adap = new SqlDataAdapter(sql, conn);
            tbl = new DataTable();
            adap.Fill(tbl);
            key[0] = tbl.Columns[0];
            tbl.PrimaryKey = key;
        }
        public bool inSert_ThanhToan_ToaThuoc(THANH_TOAN_DTO tmp)
        {
            try
            {
                DataRow dr = tbl.NewRow();
                dr[0] = tmp.MaThanhToan;
                dr[1] = null;
                dr[2] = null;
                dr[3] = tmp.SoTien.ToString();
                dr[4] = DateTime.Now.ToString("yyyy-MM-dd");
                tbl.Rows.Add(dr);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
                adap.Update(tbl);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int Dem_SL_ToaThuoc()
        {
            string ngay = DateTime.Today.ToString("yyyy-MM-dd");
            int t = 2;
            t = tbl.Select("NgayThanhToan='" + ngay + "'").Length;
            return t;
        }
    }
}
