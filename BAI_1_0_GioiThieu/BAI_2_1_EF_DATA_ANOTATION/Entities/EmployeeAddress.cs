using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_EF_DATA_ANOTATION.Entities
{
    public class EmployeeAddress
    {
        // Mỗi Employee chỉ có 1 địa chỉ => Lấy EmployeeId làm khoá chính cho bảng EmployeeAddress, đồng thời nó cũng là khoá ngoại trong bảng Employee
        [Key,ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public string City { get;set; }
        public string Address { get;set; }
        public string Province { get;set; }

        // Navigation Properties
        public virtual Employee Employee { get; set; }
    }
}
