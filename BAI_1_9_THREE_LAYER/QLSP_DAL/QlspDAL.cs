using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace QLSP_DAL
{
    public class QlspDAL
    {
        private readonly string _connString = @"Data Source=DESKTOP-1G5E96S\SQLEXPRESS;Initial Catalog=qlbh;Integrated Security=True";

        public DataTable getDanhMuc()
        {
            //query
            String query = "SELECT * from Danhmuc d";
            return getDataTable(query);
        }
        public DataTable getCungCap()
        {
            //query
            String query = "SELECT * from CungCap";
            return getDataTable(query);
        }
        public DataTable getSanPham()
        {
            //query
            String query = "SELECT * from SanPham";
            return getDataTable(query);
        }



        private DataTable getDataTable(string query,List<SqlParameter> sqlParamerters = null)
        {
            DataTable result  = new DataTable();
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    // Nếu sqlparam không null và có tối thiểu 1 param thì truyền vào
                    if(sqlParamerters!=null && sqlParamerters.Any())
                    {
                        adapter.SelectCommand.Parameters.AddRange(sqlParamerters.ToArray());
                    }
                    // Đổ dữ liệu từ sql data adapter sang datatable
                    adapter.Fill(result);
                    return result;
                }
            }catch(Exception ex)
            {
                return new DataTable();
            }
        }

        private bool excuteCommand(string query, List<SqlParameter> sqlParamerters = null)
        {
            // try thực hiện thao tác với database thì thêm vào trycatch
            try
            {
                // SqlConnection :đối tượng dùng để kết nối đến database
                // truyền vào connection string
                // 
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open(); // gọi cái này để mở kết nối đến database
                    //SqlCommand dùng cho các lệnh cập nhật database
                    // insert, update, delete
                    // truyền vào query, SqlConnection
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // nếu sqlParamerters có thì thêm vào
                    if (sqlParamerters != null && sqlParamerters.Any())
                    {
                        cmd.Parameters.AddRange(sqlParamerters.ToArray());
                    }
                    //thực hiện query
                    // thực thi
                    return cmd.ExecuteNonQuery() > 0;

                }
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
