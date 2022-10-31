using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App_Web_QUANLYBANHANG_2050531200155.App_Code
{
    public class CART
    {
        Dictionary<string, ITEM> listcarts;
        public Dictionary<string, ITEM> LISTCARTS
        {
            get { return this.listcarts; }
        }
        public CART()
        {
            listcarts = new Dictionary<string, ITEM>();
        }
        public void AddCart(String masanpham, string tensanpham, string hinhanh,
       int soluong, double dongia)
        {
            ITEM item = new ITEM(masanpham, tensanpham, hinhanh, soluong, dongia);

            if (listcarts.ContainsKey(item.MASANPHAM))
                listcarts[item.MASANPHAM].SOLUONG += item.SOLUONG;
            else
                listcarts.Add(item.MASANPHAM, item);
        }
        public void RemoveCart(String masanpham)
        {
            listcarts.Remove(masanpham);
        }
        public double TotalBill()
        {
            double total = 0;
            foreach (ITEM item in listcarts.Values)
                total += item.THANHTIEN;
            return total;
        }
    }
}