using BAI_1_9_EF_DATABASE_FIRST.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_9_EF_DATABASE_FIRST
{
    internal class Program
    {
        public static void vidu1()
        {
            List<Sanpham> sanPhams;
            using (var context = new QlbhContext())
            {
                sanPhams = context.Sanphams.ToList();
                // Qua EF API => select * from sanpham;
            }
            foreach (var x in sanPhams)
            {
                Console.WriteLine(String.Format("{0, 55} {1,-10} {2,-10} {3,-10} {4,-10}", x.TenSanpham, x.DanhmucID, x.CungcapID, x.Donvi, x.Gia));

            }
            Console.ReadLine();
        }

        public static void vidu2()
        {
            var rs = new List<SanPhamViewDto>();
            using (var context = new QlbhContext())
            {
                // Linq
                 rs = (from sanpham in context.Sanphams
                          join cungcap in context.Cungcaps on sanpham.CungcapID equals cungcap.CungcapID
                          join danhmuc in context.Danhmucs on sanpham.DanhmucID equals danhmuc.DanhmucID
                          select new SanPhamViewDto
                          {
                              TenSanpham = sanpham.TenSanpham,
                              TenCungCap = cungcap.Tendaydu,
                              TenDanhMuc = danhmuc.TenDanhMuc,
                              Gia = sanpham.Gia,
                              Donvi = sanpham.Donvi
                          }).ToList();
            }
            foreach (var x in rs)
            {
                Console.WriteLine(String.Format("{0, -55} {1,-20} {2,-20} {3,-10} {4,-10}", x.TenSanpham, x.TenDanhMuc, x.TenCungCap, x.Donvi, x.Gia));

            }
            Console.ReadLine();

        }

        public static void vidu3()
        {
            // Thêm mới 1 sản phẩm;
            using (var context = new QlbhContext())
            {
                // Lấy id  nhà cung cấp Trần Chí Kha
                var cungCapId = context.Cungcaps.Where(x => x.Tendaydu.Equals("Trần Chí Kha")).Select(x=>x.CungcapID).FirstOrDefault();
                // Lấy id danh muc
                var danhMucId = context.Danhmucs.Where(x=>x.TenDanhMuc.Equals("Ngũ cốc")).Select(x=>x.DanhmucID).FirstOrDefault();
                // Tạo mới 1 entity
                Sanpham sp = new Sanpham()
                {
                    //SanphamID là primary key database tự gen không set data
                    TenSanpham = "Gạo lứt",
                    CungcapID = cungCapId,
                    DanhmucID = danhMucId,
                    Donvi = "Gói",
                    Gia = 120000
                };
                // add vào db set
                context.Sanphams.Add(sp); // add thì chỉ lưu xuống memory(Ram)
                // Lưu vào database
                // Để lưu các thay đổi xuống db (insert,update,delete) thì gọi DBContext.SaveChanges()
                context.SaveChanges();
            }    
                
        }

        public static void vidu4()
        {
            // Thêm mới 1 sản phẩm;
            using (var context = new QlbhContext())
            {
                // Lấy ra sản phẩm cần sửa
                var sanPhams = context.Sanphams.Where(x=>x.SanphamID <8).ToList();
                // Thay đổi dữ liệu
                // sanPham.TenSanpham = "Tương cà";
                sanPhams.ForEach(x => x.TenSanpham = "Sưa All");
                // Nếu muỗn xoá 
                //context.Sanphams.Remove(sanPham);
                //
                // Lưu vào database
                // Để lưu các thay đổi xuống db (insert,update,delete) thì gọi DBContext.SaveChanges()
                context.SaveChanges();
                // Update Sanpham set TenSanpham = 'Tương cà', ... where SanphamId = 8
                Console.WriteLine("Sửa xong r");
            }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            vidu4();
        }
    }
}
