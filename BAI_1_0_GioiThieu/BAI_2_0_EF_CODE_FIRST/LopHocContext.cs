using BAI_2_0_EF_CODE_FIRST.Entities;
using System.Data.Entity;

namespace BAI_2_0_EF_CODE_FIRST
{
    public class LopHocContext:DbContext
    {
        // Constructor truyền vào
        // base class "name=[Tên connection string]"
        // Tên connection string sẽ khai báo trong App.Config
        public LopHocContext():base("name=LopHocConnection")
        {
            // Tạo ra database nếu như chưa tồn tại
            Database.SetInitializer<LopHocContext>(new DropCreateDatabaseIfModelChanges<LopHocContext>());
        }
        public DbSet<LopHoc> lopHocs { get; set; }
        public DbSet<SinhVien> sinhViens { get; set; }
    }
}
