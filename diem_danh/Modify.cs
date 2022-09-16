﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace diem_danh
{
    internal class Modify
    {
        public Modify() // khoi tao contructor
        {

        }
        SqlCommand sqlCommand; // khoi tao cau lenh truy van
        SqlDataReader dataReader;// dung de doc data trong bang

        public List<TaiKhoan> TaiKhoans(string query) // dung de check tai khoan
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                // using thuc hien xong xoa toan bo cau lenh
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader(); // tien hanh doc
                while (dataReader.Read())
                {   
                    // bien string GetString, bien int GetInt 
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return taiKhoans; // return list co chua tai khoan
        }
        public void Command(string query) // dung de insert (dang ki tai khoan) // query command
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); // thuc thi cau truy van
                sqlConnection.Close();
            }
        }
    }
}