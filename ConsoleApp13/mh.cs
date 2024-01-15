using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class mh
    {
        protected string maso;
        protected string ten;
        protected string dvt;
        protected int soluong;
        protected int dongia;
        public int getdongia()
        {
            return dongia;
        }
        public string getten()
        {
            return ten;
        }
        public virtual void nhap()
        {
            Console.WriteLine("nhao ma so: ");
            maso = Console.ReadLine();
            Console.WriteLine("nhap ten: ");
            ten = Console.ReadLine();
            Console.WriteLine("nhap don vi: ");
            dvt = Console.ReadLine();
            Console.WriteLine("nhap so luong: ");
            soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap don gia: ");
            dongia = int.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("ma so: " + maso);
            Console.WriteLine("ten: " + ten);
            Console.WriteLine("don vi tinh: " + dvt);
            Console.WriteLine("so luong: " + soluong);
            Console.WriteLine("don gia: " + dongia);
        }
        public mh()
        {
            maso = "";
            ten = "";
            dvt = "vnd";
            soluong = 0;
            dongia = 1000;
        }
        public mh(string maso, string ten, string dvt, int soluong, int dongia)
        {
            this.maso = maso;
            this.ten = ten;
            this.dvt = dvt;
            this.soluong = soluong;
            this.dongia = dongia;
        }
    }
}
