using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BAC_SI_DAL
    {
        dbContext dbContext = new dbContext();
        string sql = "SELECT * FROM BACSI";
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tbl;
        DataColumn[] key = new DataColumn[1];

        public BAC_SI_DAL()
        {
            conn = new SqlConnection(dbContext.strcon);
            adap = new SqlDataAdapter(sql, conn);
            tbl = new DataTable();
            adap.Fill(tbl);
            key[0] = tbl.Columns[0];
            tbl.PrimaryKey = key;
        }

        // Lấy tất cả dữ liệu từ bảng BACSI
        public List<BAC_SI_DTO> get_all()
        {
            List<BAC_SI_DTO> ds = new List<BAC_SI_DTO>();
            foreach (DataRow dr in tbl.Rows)
            {
                BAC_SI_DTO tmp = new BAC_SI_DTO(
                    dr["MaBacSi"].ToString(),
                    dr["HoTen"].ToString(),
                    dr["MaKhoa"].ToString(),
                    dr["SoDienThoai"].ToString(),
                    int.Parse(dr["SoCaTruc"].ToString()),
                    dr["MatKhau"].ToString(),
                    dr["ChucVu"].ToString()
                );
                ds.Add(tmp);
            }
            return ds;
        }

        // Thêm bác sĩ
        public bool Them_BacSi(BAC_SI_DTO tmp)
        {
            try
            {
                DataRow dr = tbl.NewRow();
                dr["MaBacSi"] = tmp.MaBacSi;
                dr["HoTen"] = tmp.HoTen;
                dr["MaKhoa"] = tmp.MaKhoa;
                dr["SoDienThoai"] = tmp.SoDienThoai;
                dr["SoCaTruc"] = tmp.SoCaTruc;
                dr["MatKhau"] = tmp.MatKhau;
                dr["ChucVu"] = tmp.ChucVu;
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

        // Sửa thông tin bác sĩ
        public bool Sua_BacSi(BAC_SI_DTO tmp)
        {
            foreach (DataRow dr in tbl.Rows)
            {
                if (dr["MaBacSi"].ToString().Trim() == tmp.MaBacSi.Trim())
                {
                    dr["HoTen"] = tmp.HoTen;
                    dr["MaKhoa"] = tmp.MaKhoa;
                    dr["SoDienThoai"] = tmp.SoDienThoai;
                    dr["SoCaTruc"] = tmp.SoCaTruc;
                    dr["MatKhau"] = tmp.MatKhau;
                    dr["ChucVu"] = tmp.ChucVu;
                    SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adap);
                    adap.Update(tbl);
                    return true;
                }
            }
            return false;
        }

        // Xóa bác sĩ
        public bool Xoa_BacSi(string maBacSi)
        {
            try
            {
                foreach (DataRow dr in tbl.Rows)
                {
                    if (dr["MaBacSi"].ToString().Trim() == maBacSi.Trim())
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
    }
}
