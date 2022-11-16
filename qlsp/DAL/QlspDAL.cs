using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class QlspDAL
    {
        private readonly string _connString;

        public DataTable getDanhMuc()
        {
            string query = @"select * from Danhmuc d ;";
            return getDataTable(query);
        }
        public DataTable getCungCap()
        {
            string query = @"SELECT * from Cungcap c ;";
            return getDataTable(query);
        }
        public DataTable getSanPham()
        {

            string query = @"select * from Sanpham";
            return getDataTable(query);
        }

        public DataTable getSanPham(SanPhamSearchDto sanPhamSearch)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            var querySearch = "";
            if (!string.IsNullOrEmpty(sanPhamSearch.searchKey))
            {
                querySearch += @" and TenSanpham like @searchKey";
                param.Add(new SqlParameter("searchKey", $@"%{sanPhamSearch.searchKey}%"));
            }
            if (sanPhamSearch.danhMucId != null)
            {
                querySearch += @" and DanhmucID = @danhMucId";
                param.Add(new SqlParameter("danhMucId", sanPhamSearch.danhMucId));
            }

            if (sanPhamSearch.cungCapId != null)
            {
                querySearch += @" and CungcapID = @CungcapID";
                param.Add(new SqlParameter("CungcapID", sanPhamSearch.cungCapId));
            }

            string query = @$"select * from Sanpham where 1=1 {querySearch}";
            return getDataTable(query,param);
        }

        public bool addSanPham()
        {
            var sql = @$"INSERT INTO qlbh.dbo.Sanpham
(TenSanpham, CungcapID, DanhmucID, Donvi, Gia)
VALUES(N'@TenSanpham', @CungcapID, @DanhmucID, N'', 12000.00);
";
            var param = new List<SqlParameter>();
            param.Add();
        }

        private DataTable getDataTable(string sql,List<SqlParameter> param = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    if(param!= null && param.Any())
                    {
                        adapter.SelectCommand.Parameters.AddRange(param.ToArray());
                    }
                    adapter.Fill(dt);

                }
                return dt;
            }catch(Exception ex)
            {
                return new DataTable();
            }
        }
        private bool saveToDB(string sql,List<SqlParameter> param)
        {
            bool result;
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddRange(param.ToArray());
                    result = cmd.ExecuteNonQuery() > 0;
                    
                }
                return result;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
