using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_EF_DATA_ANOTATION.Entities
{
    /// <summary>
    /// Data Anotation
    /// là những attribute thêm vào class hoặc properties để cấu hình nâng cao cho Ef
    /// Có 2 nhóm DataAnotation:
    ///     + Data Modelling Attributes
    ///     + Validation Attributes
    ///* Data Modelling Attr:
    ///     -Table: set tên của bảng trong database thay vì đặt tên là tên domain class
    ///     -Column: set tên của cột trong DB
    ///     -ForeignKey: set foreignkey properties
    ///     -NotMapped: Bỏ qua properties không tạo cột trong db
    ///* validation Attr:
    ///     - Key: Chỉ định property làm Pk
    ///     - Required: chỉ định cột là non-nullable
    ///     - MaxLength: chỉ định độ dài tối đa cho dữ liệu của cột
    ///     - MinLength: chỉ định độ dài tối thiểu cho dữ liệu của cột
    ///     - StringLength: chỉ định độ dài trong khoảng cho dữ liệu của cột
    /// </summary>
    [Table("NhanVien")]    
    
    public class Employee
    {
        public int Id { get; set; }
        [Column("TenNhanVien")]
        [MaxLength(50)]
        [DataType("Nvarchar")] // chỉ định kiểu dữ liệu cho cột trong database
        public string Name { get; set; }
        public int Age { get; set; }

        public int DepartmentId { get; set; }
        public int TeamId { get; set; }

        //Navigation Prop
        public virtual Department Department { get; set; }
        public virtual Team Team { get; set; }
        public virtual EmployeeAddress Address { get; set; }
    }
}
