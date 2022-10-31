using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_Web_QUANLYBANHANG_2050531200155
{
    public partial class pageGioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            App_Code.CART cart = (App_Code.CART)Session["CART"];
            this.gridviewGiohang.DataSource = cart.LISTCARTS.Values.ToList();
            this.gridviewGiohang.DataBind();
            this.gridviewGiohang.FooterRow.Cells[0].Text = "Tổng tiền = ";
            this.gridviewGiohang.FooterRow.Cells[4].Text = cart.TotalBill().ToString();

        }
    }
}