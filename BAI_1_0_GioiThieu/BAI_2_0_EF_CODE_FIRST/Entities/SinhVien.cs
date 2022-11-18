using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_0_EF_CODE_FIRST.Entities
{
    public class SinhVien
    {
        public int SinhVienId { get; set; }
        public string TenDayDu { get; set; }
        public int Tuoi { get; set; }
        public string DiaChi { get; set; }
        public int GioiTinh { get; set; }

        // Navigation properties
        public int LopHocId { get; set; }
        public LopHoc LopHoc { get; set; }
    }
}
