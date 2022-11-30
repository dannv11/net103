using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_0_EF_CODE_FIRST.Entities
{
    /// <summary>
    /// Quy ước mặc định code first
    /// tên column được đặt theo tên thuộc tính, bao gồm tất cả thuộc tính public có getter và setter
    /// Ef tạo ra column trong DB theo thứ tự của properties trong domain class nhưng pk sẽ được đưa lên đầu
    /// *Pk: Ef không cho phép tạo bảng mà không có Pk,
    /// + EF check thuộc tính có tên là Id hoặc <className>Id và chỉ định nó làm khoá chính
    /// + Không có khoá chính, ef sẽ thow ex
    /// </summary>
    public class LopHoc
    {
        public int LopHocId { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }

        // 
        public virtual List<SinhVien> SinhViens { get; set; }
    }
}
