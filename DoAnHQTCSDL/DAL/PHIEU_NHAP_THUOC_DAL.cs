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
    public class PHIEU_NHAP_THUOC_DAL
    {
        string connStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=QLBV;Integrated Security=True";
        string sql = "select * from PHIEU_NHAP_THUOC";
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tbl;
        DataColumn[] key = new DataColumn[1];
        public PHIEU_NHAP_THUOC_DAL()
        {
            conn = new SqlConnection(connStr);
            adap = new SqlDataAdapter(sql, conn);
            tbl = new DataTable();
            adap.Fill(tbl);
            key[0] = tbl.Columns[0];
            tbl.PrimaryKey = key;
        }
        public int Dem_SL_PN()
        {
            string ngay = DateTime.Today.ToString("yyyy-MM-dd");
            int t = 2;
            t = tbl.Select("NgayNhap='" + ngay + "'").Length;
            return t;
        }
        public bool insert_PN(PHIEU_NHAP_THUOC_DTO tmp)
        {
            try
            {
                DataRow dr= tbl.NewRow();
                dr[0] = tmp.MaPN;
                dr[1] = tmp.MaNCC;
                dr[2] = DateTime.Today.ToString("yyyy-MM-dd");
                dr[3] = tmp.ThanhTien.ToString();
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

    }

}
