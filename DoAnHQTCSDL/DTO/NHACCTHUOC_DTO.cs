using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NHACCTHUOC_DTO
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public NHACCTHUOC_DTO()
        {

        }
        public NHACCTHUOC_DTO(string maNCC, string tenNCC, string diaChi)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            DiaChi = diaChi;
        }
    }
}
