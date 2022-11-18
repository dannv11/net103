using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_0_EF_CODE_FIRST.Entities
{
    public class LopHoc
    {
        public int LopHocId { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }

        // 
        public List<SinhVien> SinhViens { get; set; }
    }
}
