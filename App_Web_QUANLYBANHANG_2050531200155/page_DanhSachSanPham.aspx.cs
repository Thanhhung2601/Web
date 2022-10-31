using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace App_Web_QUANLYBANHANG_2050531200155
{
    public partial class page_DanhSachSanPham : System.Web.UI.Page
    {
        App_Code.XuLyData xuLyData;
        protected void Page_Load(object sender, EventArgs e)
        {
            xuLyData = new App_Code.XuLyData();
            string madm = Request.QueryString.Get("MADANHMUC");
            SqlParameter[] pr;
            if (madm != null)
                pr = new SqlParameter[] { new SqlParameter("@MADANHMUC", madm) };
            else
                pr = new SqlParameter[] { new SqlParameter("@MADANHMUC", DBNull.Value) };

            DataList1.DataSource = xuLyData.getTable("psGetSanPham", pr);
            DataList1.DataBind();
            DataList1.RepeatColumns = 3;

            
        }
    }
}