using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_2_EF_fLUENT_API
{
    public class Program
    {
        /*
         Fluent API là cách chỉ định cấu trúc cơ sở dữ liệu thứ hai trong Entity Framework Code first
❑Cấu hình này sử dụng classDbModelBuilder với 
chuỗi phương thức (method chaining) ghép nối 
với nhau
❑Để dùng Fluent API, bạn có thể ghi đè (override) 
lên phương thức OnModelCreating ở DbContext
         */

        static void Main(string[] args)
        {
            using (var ctx = new StudentContext())
            {
                ctx.Database.CreateIfNotExists();
            }
        }
    }
}
