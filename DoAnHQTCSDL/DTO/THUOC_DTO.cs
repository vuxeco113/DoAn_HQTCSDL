using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class THUOC_DTO
    {
        public string MaThuoc { get; set; }
        public string TenThuoc { get;set; }
        public string ThanhPhan { get; set; }
        public float Gia { get; set; }
       
        public THUOC_DTO() { }
        public THUOC_DTO(string maThuoc, string tenThuoc, string thanhPhan, float gia)
        {
            MaThuoc = maThuoc;
            TenThuoc = tenThuoc;
            ThanhPhan = thanhPhan;
            Gia = gia;
        }
    }
}
