using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BAI_1_8_ADO_NET
{
    
    internal class SqlDemo
    {
        // Khai bao Connection string
        private readonly string _connString = @"Data Source=DESKTOP-1G5E96S\SQLEXPRESS;Initial Catalog=qlbh;Integrated Security=True";

        // vd1: test kết nối
        public void tryConnect()
        {
            try
            {
                // Khai báo đối tượng SqlConnection để kết nối tới database
                // Tham số truyền vào SqlConnection khi khởi tạo là 
                // chuỗi Connection string
                SqlConnection conn = new SqlConnection(_connString);

                // mở kết nối tới database
                conn.Open();
                // todo something with database
                Console.WriteLine("Connect Ok!");

                //đóng kết nối
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Can't connect to database");
            }
        }

        #region SqlCommand
        //Sql command 1: insert
        /*
            Đối tượng Command có một số phương thức 
            sau:
            ❖ExecuteScalar(): Thực hiện câu lệnh mà kết quả trả về 
            chỉ có 1 ô (Ví dụ câu lệnh Select Count(*)…).
            ❖ExecuteReader(): Thực hiện câu lệnh Select và trả về 
            một DataReader
            ❖ExecuteNonQuery(): Thực hiện câu lệnh OLEDB nhưng 
            không trả về kết quả (Delete, Update, Insert …).
            ❖ExecuteXMLReader(): Tạo một bộ đọc từ file XML. 
            Phương thức này không có trong OleDbCommand, 
            chỉ có trong SqlCommand*/

        public void insert()
        {
            //Khối thẻ using: Sử dụng với các class implement interface
            // IDisposable
            // tác dụng: tự động đóng connection, ngắt kết nối với tệp tin ...
            // thay vì phải gọi phương thức đóng thủ công

            try
            {
                //var query = @"
                //                INSERT INTO qlbh.dbo.Sanpham
                //( TenSanpham, CungcapID, DanhmucID, Donvi, Gia)
                //VALUES( N'Hạt Nêm Knorrrrrr Từ Thịt Thăn', 12, 2, N'túi', 20000.00);";
                var query = "update Sanpham set Gia = 25000 where SanphamID = 78";
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open(); // mở kết nối tới database
                    // đối tượng SQlCommand: tương tác các lệnh với database
                    // truyền vào SqlCommand(chuỗi query, đối tượng Connection)
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Thực hiện truy vấn không trả về dữ liệu
                    // tương tự với truy vấn update, delete
                    //ExecuteNonQuery() thực hiện câu lệnh truy vấn và trả
                    // về số bản ghi trong database mà nó tác động lên
                    if (cmd.ExecuteNonQuery()>0)
                    {
                        Console.WriteLine("Thực hiện thành công");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thực hiện không thành công!");
            }
        }

        /*
            ❑Đọc dữ liệu với SqlDataReader:
            ❖Đối tượng DataReader được .NET Framework cung 
            cấp nhằm phục vụ việc truy cập vào cơ sở dữ liệu 
            nhanh và hiệu quả cụ thể là việc đọc dữ liệu từ 
            Database
            ❖DataReader chỉ xử lý 1 record tại một thời điểm và chỉ 
            được truy xuất 1 chiều, không có các thao tác phức 
            tạp như sắp xếp hay truy xuất bất cứ record ngẫu 
            nhiên nào*/
        public void select()
        {
            try
            {
                var query = "Select TenSanpham ,Gia from Sanpham";
                using(var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query,conn);
                    // SqlCommand.ExecuteReader trả về đối tượng SqlDataReader
                    SqlDataReader reader = cmd.ExecuteReader();

                    //Đọc dữ liệu với SqlDataReader
                    while(reader.Read())
                    {
                        // lấy getString hay get[Kiểu dữ liệu] phụ thuộc vào kiểu dữ liệu của
                        // trường đó trong database
                        // Console.WriteLine($"{reader.GetString(0)} {reader.GetDecimal(1)}");

                        Console.WriteLine($"{reader["TenSanpham"]}  {reader["Gia"]}");
                    }
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Có lỗi trong quá trình thực thi");
            }
        }

        #endregion

    }
}
