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

    public partial class chiTiet2 : System.Web.UI.Page
    {
        App_Code.XuLyData xuLyData;
        DataTable tbSanPham;
        protected void Page_Load(object sender, EventArgs e)
        {
            xuLyData = new App_Code.XuLyData();
            string masanpham = Request.QueryString.Get("MSP");
            SqlParameter[] pr;
            if (masanpham != null)
                pr = new SqlParameter[] { new SqlParameter("@MaSanPham", masanpham) };
            else
                pr = new SqlParameter[] { new SqlParameter("@MaSanPham", DBNull.Value) };
            tbSanPham = xuLyData.getTable("psGetChiTietSanPham", pr);
            Repeater3.DataSource = tbSanPham;
            Repeater3.DataBind();
            int soLuong = Convert.ToInt32(tbSanPham.Rows[0]["Soluong"].ToString());
            for(int i = 1; i <= soLuong; i++)
            {
                this.drlGioHangg.Items.Add(i.ToString());
            }
        }

        protected void btnGioHangg_Click(object sender, EventArgs e)
        {
            Session.Timeout = 2;
            App_Code.CART cart = new App_Code.CART();
            if (tbSanPham != null)
            {
                String masanpham = tbSanPham.Rows[0]["MaSanPham"].ToString();
                String tenSanpham = tbSanPham.Rows[0]["TenSanPham"].ToString();
                double dongia = Double.Parse(tbSanPham.Rows[0]["DonGia"].ToString());
                String hinhanh = tbSanPham.Rows[0]["HinhAnh"].ToString();
                int soluong = Int16.Parse(drlGioHangg.SelectedItem.Text);
                if (Session["CART"] != null)
                    cart = (App_Code.CART)Session["CART"];
                cart.AddCart(masanpham, tenSanpham, hinhanh, soluong, dongia);
                Session["CART"] = cart;
                Response.Redirect("pageGioHang.aspx");
            }
        }
    }
}