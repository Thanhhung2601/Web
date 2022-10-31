using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_Web_QUANLYBANHANG_2050531200155
{
    public partial class TT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                ListItem item = new ListItem();
                item.Text = i.ToString();
                ListBox1.Items.Add(item);
            }
            this.gridTest.Items.Add("NguyenThanhHung");
        }
    }
}