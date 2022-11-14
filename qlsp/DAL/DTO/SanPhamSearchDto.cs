using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DTO
{
    public class SanPhamSearchDto
    {
        public string searchKey { get; set; }
        public int? danhMucId { get; set; }
        public int? cungCapId { get; set; }

    }
}
