using System;

namespace BAI_1_8_ADO_NET
{
    internal class Program
    {
        #region SQL Connection, SqlCommand
        /*
            ADO.NET là một bộ các thư viện hướng đối 
            tượng (OOP) cho phép bạn tương tác với dữ liệu 
            nguồn.
            ❑Mục tiêu chính của ADO.NET là:
            ❖Cung cấp các lớp để thao tác CSDL trong cả hai môi 
            trường là phi kết nối (Disconected data) và kết nối 
            (Connected data).
            ❖Tương tác với nhiều nguồn dữ liệu thông qua mô tả 
            dữ liệu chung
            ❖Tối ưu truy cập nguồn dữ liệu (OleDb & SQL server).
            TỔNG QUAN VỀ ADO.NET
            ❑Các lớp của ADO.NET được đặt trong 
            Namespace là System.Data. ADO.NET bao gồm 2 
            Provider (2 bộ thư viện) (thường dùng) để thao 
            tác với các CSDL là:
            ❖OleDb Provider (nằm trong System.Data.OleDb) dùng 
            để truy xuất đến bất kỳ CSDL nào có hỗ trợ OleDb
            ❖SQL Provider (nằm trong System.Data.SQLClient) 
            chuyên dùng để truy xuất đến CSDL SQL Server */


        /*

        Đối tượng SqlConnection
        ❖Để tương tác với database, bạn phải có một kết nối 
        tới nó
        ❖Kết nối giúp xác định database server, database name, 
        user name, password, và các tham số cần thiết  để kết 
        nối tới database
        ❖Một đối tượng connection được dùng bởi đối tượng 
        command vì thế chúng sẽ biết database nào để thực 
        thi lệnh
        ❖Đối tượng Connection có hai phương thức hay dùng 
        là Open() để mở kết nối tới CSDL và Close() để đóng 
        kết nối tới CSDL
        CÁC ĐỐI TƯỢNG CỦA ADO.NET
        ❑Sql Connection String chứa các cặp key/value để 
        xác định cách tạo một kết nối đến database. 
        Chúng bao gồm vị trí, tên của database và và chế 
        độ bảo mật. */
        /*
        Đối tượng SqlCommand:
        ❖cho phép bạn chọn kiểu tương tác mà bạn muốn thực 
        hiện với database.
        ❖có thể thực hiện các lệnh select, insert, modify, và 
        delete các dòng trong một table của database
        ❖Đối tượng này có thể được dùng để hỗ trợ mô hình 
        quản lý dữ liệu ngắt kết nối (disconnected) */
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            SqlDemo demo = new SqlDemo();

            // demo.tryConnect();
            demo.select();
        }
        

    }
}
