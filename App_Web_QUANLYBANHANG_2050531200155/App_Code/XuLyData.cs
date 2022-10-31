using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace App_Web_QUANLYBANHANG_2050531200155.App_Code
{
    public class XuLyData
    {
        SqlConnection con;
        public XuLyData()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LinhTinh\linhtinh1\App_Web_QUANLYBANHANG_2050531200155\App_Web_QUANLYBANHANG_2050531200155\App_Data\quanLyBanHang.mdf;Integrated Security=True";

        }

        private void MoKetNoi()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void DongKetNoi()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public DataTable getTable(String sql)
        {
            this.MoKetNoi();
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            this.DongKetNoi();
            return tb;
        }

        public DataTable getTable(String nameprocedure, SqlParameter[] pr)
        {
            this.MoKetNoi();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nameprocedure;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(tb);
            this.DongKetNoi();
            return tb;
        }

        public void getDataSet(ref DataSet ds, String sql)
        {
            ds.Tables.Add(this.getTable(sql));
        }

        public void getDataSet(ref DataSet ds, String nameprocedure, SqlParameter[] pr)
        {
            ds.Tables.Add(this.getTable(nameprocedure, pr));
        }

        public int Execute(string sql)
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, this.con);
            this.DongKetNoi();
            int k = (int)cmd.ExecuteNonQuery();
            return k;
        }

        public int Execute(String nameprocedure, SqlParameter[] pr)
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nameprocedure;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            this.DongKetNoi();
            int k = (int)cmd.ExecuteNonQuery();
            return k;
        }
    }
}