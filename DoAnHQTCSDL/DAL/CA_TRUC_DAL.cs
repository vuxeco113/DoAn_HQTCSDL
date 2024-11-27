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
        public List<CA_TRUC_DTO> get_all()
        {
            List<CA_TRUC_DTO> list = new List<CA_TRUC_DTO>();
            using (SqlConnection conn = new SqlConnection(dbContext.strcon))
            {
                conn.Open();
                string query = "SELECT MaCaTruc, ThoiGianCa FROM CaTruc";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CA_TRUC_DTO catruc = new CA_TRUC_DTO
                            {
                                MaCaTruc = reader["MaCaTruc"].ToString(),
                                ThoiGianCa = reader["ThoiGianCa"].ToString()
                            };
                            list.Add(catruc);
                        }
                    }
                }
            }
            return list;
        }


    }
}
