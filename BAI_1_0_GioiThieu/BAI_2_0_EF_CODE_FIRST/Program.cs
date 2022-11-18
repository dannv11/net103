using BAI_2_0_EF_CODE_FIRST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_0_EF_CODE_FIRST
{
    
    public class Program
    {

        public static void addLopHoc()
        {
            LopHoc lopHoc = new LopHoc()
            {
                MaLop = "NET103",
                TenLop = "Lập trình c# 3"
            };
            using (var ctx = new LopHocContext())
            {
                ctx.lopHocs.Add(lopHoc);

                ctx.SaveChanges(); // Lưu vào database
            }
        }

        public static void addSinhVien()
        {
            using (var ctx = new LopHocContext())
            {
                var lopHoc = ctx.lopHocs.FirstOrDefault();
                if(lopHoc!=null)
                {
                    var sinhViens = new List<SinhVien>()
                    {
                        new SinhVien()
                        {
                            TenDayDu = "Sinh Viên 1",
                            GioiTinh = 1,
                            LopHocId = lopHoc.LopHocId,
                            DiaChi = "Hà Nội",
                            Tuoi = 19,
                            
                        },
                        new SinhVien()
                        {
                            TenDayDu = "Sinh Viên 2",
                            GioiTinh = 1,
                            LopHocId = lopHoc.LopHocId,
                            DiaChi = "Thái Bình",
                            Tuoi = 19,

                        },
                        new SinhVien()
                        {
                            TenDayDu = "Sinh Viên 3",
                            GioiTinh = 1,
                            LopHocId = lopHoc.LopHocId,
                            DiaChi = "Nam Định",
                            Tuoi = 19,

                        },
                    };
                    // Nếu add 1 object thì gọi phương thức Add()
                    // Nếu add 1 collection thì dùng phương thức AddRange(
                    ctx.sinhViens.AddRange(sinhViens);
                }

                ctx.SaveChanges(); // Lưu vào database
            }
        }

        public static void showData()
        {
            var LopHoc = new List<LopHoc>();
            var sinhViens = new List<SinhVien>();
            using (var ctx = new LopHocContext())
            {
                // lazy loading
                // Dynamic Proxies
                LopHoc = ctx.lopHocs.ToList();
                sinhViens = ctx.sinhViens.ToList();
                
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            addLopHoc();
            addSinhVien();
            showData();
        }
    }
}
