using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LICH_TRUC_DAL
    {
        dbContext dbContext = new dbContext();
        string sql = "SELECT * FROM LICHTRUC";
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tbl;
        DataColumn[] key = new DataColumn[1];

        public LICH_TRUC_DAL()
        {
            conn = new SqlConnection(dbContext.strcon);
            adap = new SqlDataAdapter(sql, conn);
            tbl = new DataTable();
            adap.Fill(tbl);
            key[0] = tbl.Columns[0]; // Đặt MaLichTruc làm khóa chính
            tbl.PrimaryKey = key;
        }

        // Lấy danh sách tất cả lịch trực
        public List<LICH_TRUC_DTO> GetAll()
        {
            List<LICH_TRUC_DTO> ds = new List<LICH_TRUC_DTO>();
            foreach (DataRow dr in tbl.Rows)
            {
                LICH_TRUC_DTO tmp = new LICH_TRUC_DTO(
                    dr["MaLichTruc"].ToString(),
                    dr["MaBacSi"].ToString(),
                    DateTime.Parse(dr["NgayTruc"].ToString()),
                    dr["MaCaTruc"].ToString()
                );
                ds.Add(tmp);
            }
            return ds;
        }

        // Thêm lịch trực
        public bool ThemLichTruc(LICH_TRUC_DTO tmp)
        {
            try
            {
                DataRow dr = tbl.NewRow();
                dr["MaLichTruc"] = tmp.MaLichTruc;
                dr["MaBacSi"] = tmp.MaBacSi;
                dr["NgayTruc"] = tmp.NgayTruc;
                dr["MaCaTruc"] = tmp.MaCaTruc;
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

        // Sửa lịch trực
        public bool SuaLichTruc(LICH_TRUC_DTO tmp)
        {
            try
            {
                foreach (DataRow dr in tbl.Rows)
                {
                    if (dr["MaLichTruc"].ToString().Trim() == tmp.MaLichTruc.Trim())
                    {
                        dr["MaBacSi"] = tmp.MaBacSi;
                        dr["NgayTruc"] = tmp.NgayTruc;
                        dr["MaCaTruc"] = tmp.MaCaTruc;

                        SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adap);
                        adap.Update(tbl);
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Xóa lịch trực
        public bool XoaLichTruc(LICH_TRUC_DTO tmp)
        {
            try
            {
                foreach (DataRow dr in tbl.Rows)
                {
                    if (dr["MaLichTruc"].ToString().Trim() == tmp.MaLichTruc.Trim())
                    {
                        dr.Delete();

                        SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adap);
                        adap.Update(tbl);
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Đếm số lượng lịch trực trong ngày
        public int DemSoMaLichTrongNgay(DateTime ngay)
        {
            int count = 0;

            string query = "SELECT COUNT(*) FROM LICHTRUC WHERE CONVERT(DATE, NgayTruc) = @Ngay";
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ngay", ngay.Date);

                    count = (int)cmd.ExecuteScalar();
                }
            }
            return count;
        }
    }
}
