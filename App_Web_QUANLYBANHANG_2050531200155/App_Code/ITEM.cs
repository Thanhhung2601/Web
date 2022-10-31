using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App_Web_QUANLYBANHANG_2050531200155.App_Code
{
    public class ITEM
    {
        private String masanpham;
        private String tensanpham;
        private double dongia;
        private int soluong;
        private String hinhanh;
        public String MASANPHAM
        {
            set { this.masanpham = value; }
            get { return this.masanpham; }
        }
        public String TENSANPHAM
        {
            set { this.tensanpham = value; }
            get { return this.tensanpham; }
        }
        public String HINHANH
        {
            set { this.hinhanh = value; }
            get { return this.hinhanh; }
        }
        public double DONGIA
        {
            set { this.dongia = value; }
            get { return this.dongia; }
        }
        public int SOLUONG
        {
            set { this.soluong = value; }
            get { return this.soluong; }
        }
        public double THANHTIEN
        {
            get { return this.soluong * this.dongia; }
        }
        public ITEM(String masanpham, string tensanpham, string hinhanh, int
        soluong, double dongia)
        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.hinhanh = hinhanh;
            this.soluong = soluong;
            this.dongia = dongia;
        }
        public ITEM() { }
    }
}