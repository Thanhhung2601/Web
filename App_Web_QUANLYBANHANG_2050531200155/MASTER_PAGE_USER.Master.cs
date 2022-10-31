using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace App_Web_QUANLYBANHANG_2050531200155
{
    public partial class MASTER_PAGE_USER : System.Web.UI.MasterPage
    {
        App_Code.XuLyData xuLyData;                      
        protected void Page_Load(object sender, EventArgs e)
        {
            xuLyData = new App_Code.XuLyData();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@MADANHMUC", DBNull.Value);
            this.Repeater1.DataSource = xuLyData.getTable("psGetDanhMuc",pr);
            this.Repeater1.DataBind();
        }
    }
}

